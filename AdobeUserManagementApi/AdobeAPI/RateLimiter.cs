using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.AdobeAPI
{
    public abstract class RateLimiter
    {
        internal readonly SemaphoreSlim _semaphore;
        private readonly int _maxRequests;
        private readonly TimeSpan _interval;
        private DateTime _lastResetTime;
        public RateLimiter(int semaphoreLimit) 
        {
            _semaphore = new SemaphoreSlim(1);
            _maxRequests = semaphoreLimit;
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
                    _semaphore.Release(_maxRequests);
                }
                finally
                {
                    _semaphore.Release();
                }
            }
        }
    }
}
