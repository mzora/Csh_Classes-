using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Exercise 1: Design a Stopwatch
   Design a class called Stopwatch. The job of this class is to simulate a stopwatch.
   
    It should provide two methods: Start and Stop.
   
    We call the start method first, and the stop method next.
   Then we ask the stopwatch about the duration between start and stop.
   
    Duration should be a value in TimeSpan.
   Display the duration on the console.
   
    We should also be able to use a stopwatch multiple times.
   So we may start and stop it and then start and stop it again.
   Make sure the duration value each time is calculated properly.
   
    We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). 
   So the class should throw an InvalidOperationException if its started twice.
 */

namespace Exercise_StopWatch
{
    class Program
    {

        static void Main(string[] args)
        {
            var chrono = new Stopwatch();
            DateTime _start = new DateTime();
            DateTime _stop = new DateTime();

            Console.WriteLine("start chrono? type true");
            bool confirm = bool.Parse(Console.ReadLine());

            if (confirm)
            {
                _start = chrono.Start();
            }

            Console.WriteLine("stop chrono? type true");
            bool reconfirm = bool.Parse(Console.ReadLine());
            if (reconfirm)
            {
                _stop = chrono.Stop();
            }

            Console.WriteLine("type true to calc duration");
            bool treconfirm = bool.Parse(Console.ReadLine());
            if (treconfirm)
            {
                TimeSpan _durSpan = chrono.DurationCalc(_start, _stop);
                Console.WriteLine("il tempo trascorso è " + _durSpan);

            }

            Console.ReadKey();
        }
    }
}
