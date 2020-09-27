using System;
using System.Collections.Generic;
using System.Text;

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
        static public long BinarySearch(long[] array, long element)
        {
            long left = 0;
            long right = array.Length - 1;
            while (left < right)
            {
                long middle = (right + left) / 2;
                if (element <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == element)
                return right;
            return -1;
        }
        static public long[] SortArray(long[] array)
        {
            long middle;
            for (int p = 0; p < array.Length; p++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        middle = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = middle;
                    }
                }
            }
            return array;
        }
    }
}
