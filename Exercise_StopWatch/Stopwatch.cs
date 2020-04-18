using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_StopWatch
{
    class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _chronoIsOn;

        public void Start()
        {
            if (!_chronoIsOn)
            {
                _chronoIsOn = true;
                _start = DateTime.Now;
                Console.WriteLine("chrono start");
            }
            else if (_chronoIsOn)
            {
                Console.WriteLine("isn't possible to start twice");
            }
        }

        public void Stop()
        {
            if (_chronoIsOn)
            {
                _stop = DateTime.Now;
                _chronoIsOn = false;
                Console.WriteLine("chrono stop");
            }
            else
            {
                Console.WriteLine("start chrono firts!");
            }
        }

        public TimeSpan Calc()
        {
            return (_stop - _start);
        }

    }
}

