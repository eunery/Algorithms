using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Watch
    {
        public static Stopwatch timer = new Stopwatch();
        public static void TimerStart()
        {
            timer.Start();

        }
        public static void TimerStop()
        {
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
