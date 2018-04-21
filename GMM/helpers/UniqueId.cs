using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.helpers
{
    public static class UniqueId
    {
        private static int _internalCounter = 0;

        public static string Get()
        {
            var now = DateTime.Now;

            var days = (int) (now - new DateTime(2000, 1, 1)).TotalDays;
            var seconds = (int) (now - DateTime.Today).TotalSeconds;

            var counter = _internalCounter++ % 100;
            Random rnd = new Random();
            int dice = rnd.Next(1, 9);
            return days.ToString("0000") + seconds.ToString("00000") + counter.ToString("0") + dice;
        }
    }
}
