using System;
using System.Threading;

namespace Algorithms
{
    class FindNumber
    {
        static public long MaxNumber(long maxNum, long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
            }
            return maxNum;
        }
        static public long MinNumber(long minNum, long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minNum)
                {
                    minNum = array[i];
                }
            }
            return minNum;
        }
        static public long[] BinarySearch(long[] array)
        {

            return array;
        }
        static public long[] SortArray(long[] array)
        {
            long middle;
            for (int p = 0; p < array.Length; p++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        middle = array[i];
                        array[i] = array[i+1];
                        array[i+1] = middle;
                    }
                }
            }
            return array;
        }
    }
    class Program
    {
        public static long n = 1000;
        public static void ArrayFill(long[] array)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 1000);
            }
        }
        static void Main(string[] args)
        {
            long[] array = new long[n];
            ArrayFill(array);

            long maxNum = array[0];
            long minNum = array[0];

            maxNum = FindNumber.MaxNumber(maxNum, array);
            minNum = FindNumber.MinNumber(minNum, array);

            Console.WriteLine(minNum+'\n'+maxNum);

            FindNumber.SortArray(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
