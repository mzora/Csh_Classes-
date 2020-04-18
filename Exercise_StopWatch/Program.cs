using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Exercise 1: Design a Stopwatch
   __Design a class called Stopwatch.
   
    __It should provide two methods: Start and Stop.
    __We call the start method first, and the stop method next.
   __Then we ask the stopwatch about the duration between start and stop.
   
    __Duration should be a value in TimeSpan.
    __Display the duration on the console.
   
    __We should also be able to use a stopwatch multiple times.
   So we may start and stop it and then start and stop it again.
   Make sure the duration value each time is calculated properly.
   
    
    We should not be able to start a stopwatch twice in a row 
    (because that may overwrite the initial start time). 
   So the class should throw an InvalidOperationException if its started twice.

    *****************************************************************************
    Educational tip: The aim of this exercise is to make you understand that a "class" should be always in a valid state.
 
    We use encapsulation and information hiding to achieve that the class should not reveal its implementation detail. 
    It only reveals a little bit like a blackbox. 

    From the outside, you should not be able to misuse a class because you shouldn’t be able to see the implementation detail.
 */

namespace Exercise_StopWatch
{
    class Program
    {

        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("press 's' to start, 'f' to stop, 'c' to calc or 'q' to quit.");

                switch (Console.ReadLine())
                {
                    case "s":
                        stopwatch.Start();
                        break;
                    case "f":
                        stopwatch.Stop();
                        break;
                    case "c":
                        Console.WriteLine(stopwatch.Calc());
                        break;
                    case "q":
                        return;
                }

            }


            /*
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
            */
            Console.ReadKey();
        }
    }
}
