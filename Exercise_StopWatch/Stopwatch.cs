using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_StopWatch
{
    class Stopwatch
    {//public TimeSpan Duration { get; set; }

        public DateTime Start()
        {
            DateTime timeStart = DateTime.Now;
            return timeStart;
        }

        public DateTime Stop()
        {
            DateTime timeStop = DateTime.Now;
            return timeStop;
        }

        public TimeSpan DurationCalc(DateTime start, DateTime stop)
        {

            TimeSpan duration = stop - start;
            //Duration = duration;
            return duration;
        }
    }
}

