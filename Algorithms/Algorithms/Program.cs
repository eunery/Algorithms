using System;
using System.Threading;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        public static int n = 10000;
        public static void ArrayFill(long[] array)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, n);
            }
        }
        static void Main(string[] args)
        {
            long[] array = new long[n];
            ArrayFill(array);

            long maxNum = array[0];
            long minNum = array[0];
            Watch.TimerStart();
            maxNum = FindNumber.MaxNumber(maxNum, array);
            Watch.TimerStop();

            //minNum = FindNumber.MinNumber(minNum, array);

            //Console.WriteLine(maxNum + "\n" + minNum);
            //FindNumber.SortArray(array);
            //  foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(FindNumber.BinarySearch(array, 250));

        }
    }
}
