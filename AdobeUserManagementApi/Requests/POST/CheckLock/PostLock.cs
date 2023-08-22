using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Requests.POST.CheckLock
{
    internal static class PostLock
    {
        private static readonly object postLockCountDown = new object();
        private static int postLockCount = 0;
        private const int maxiumPerMinute  = 10;
        private static int seconds = 60;

        internal static bool Check()
        {
            if (postLockCount == 0)
            {
                lock (postLockCountDown)
                {
                    CountDown();
                }
                return true;
            }


            return false;
        }

        private static async void CountDown()
        {
            while (seconds != 0)
            {
                seconds--;
                await Task.Delay(1000);
            }
        }

    }
}
