using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.AdobeAPI
{
    public abstract class RateLimiter
    {
        private readonly SemaphoreSlim _semaphore;
        private readonly int _maxRequestsPerMinute;
        private readonly TimeSpan _interval;
        private DateTime _lastResetTime;
        private int _totalRequests;
        public RateLimiter(int maxRequestsPerMinute) 
        {
            _semaphore = new SemaphoreSlim(1);
            _maxRequestsPerMinute = maxRequestsPerMinute;
            _interval = TimeSpan.FromSeconds(60 /_maxRequestsPerMinute);
            _lastResetTime = DateTime.Now;
        }

        internal async Task CheckIfRequestsIsOutOfBound()
        {
            await _semaphore.WaitAsync();

            if (_totalRequests == 10)
            {
                var now = DateTime.Now;
                TimeSpan diff = now - _lastResetTime;
                if (diff <= TimeSpan.FromMinutes(1))
                {
                    await Task.Delay(_interval);
                    _lastResetTime = DateTime.Now;
                }
                _totalRequests = 0;
            }
            _totalRequests++;
            _semaphore.Release();
        }

        internal async Task ResetIfNeededAsync()
        {
            DateTime now = DateTime.Now;
            if (now - _lastResetTime > _interval)
            {
                await _semaphore.WaitAsync();
                try
                {
                    // Reset the rate limiter if the interval has passed.
                    _lastResetTime = now;
                    _semaphore.Release();
                }
                finally
                {
                    _semaphore.Release();
                }
            }
        }
    }
}
