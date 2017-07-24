using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    static class ArrayOps
    {
        public static void Fill(this int[] ary, int val)
        {
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = val;
            }
        }

        public static void Fill(this int[] ary, int begin, int end)
        {
            if (end - begin > ary.Length)
                throw new ArgumentException("Given range is greater than size of array.");

            for (int i = 0; i < end-begin; i++)
            {
                ary[i] = i + begin;
            }
        }

        public static double Max(this double[] ary)
        {
            if (ary.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            double max = ary[0];
            foreach (double val in ary)
            {
                if (val > max)
                    max = val;
            }
            return max;
        }

        public static double Min(this double[] ary)
        {
            if (ary.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            double min = ary[0];
            foreach (double val in ary)
            {
                if (val < min)
                    min = val;
            }
            return min;
        }

        public static int ArgMax(this double[] ary)
        {
            if (ary.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            double max = ary[0];
            int idx = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] > max)
                {
                    max = ary[i];
                    idx = i;
                }
            }
            return idx;
        }

        public static int ArgMin(this double[] ary)
        {
            if (ary.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            double min = ary[0];
            int idx = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] < min)
                {
                    min = ary[i];
                    idx = i;
                }
            }
            return idx;
        }

        public static void Shuffle(this int[] ary)
        {
            ShuffleImpl(ref ary, ary.Length);
        }

        public static void Shuffle(this int[] ary, int len)
        {
            ShuffleImpl(ref ary, len);
        }

        private static void ShuffleImpl(ref int[] ary, int len)
        {
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                Swap(ref ary[i], ref ary[rand.Next(i, ary.Length)]);
            }
        }

        public static double Sum(this double[] ary)
        {
            double result = 0;
            foreach (double val in ary)
            {
                result += val;
            }
            return result;
        }
        
        #region sorting
        private static int Partition(double[] data, int[] dataIdx, int leftIdx, int rightIdx)
        {
            int i = leftIdx - 1;
            for (int j = leftIdx; j < rightIdx; j++)
            {
                if (data[j] > data[rightIdx])
                {
                    i++;
                    Swap(ref data[i], ref data[j]);
                    Swap(ref dataIdx[i], ref dataIdx[j]);
                }
            }
            Swap(ref data[i + 1], ref data[rightIdx]);
            Swap(ref dataIdx[i + 1], ref dataIdx[rightIdx]);
            return i + 1;
        }

        public static void QuickSort(ref double[] data, ref int[] dataIdx, int leftIdx, int rightIdx)
        {
            if (leftIdx < rightIdx)
            {
                int pivotIdx = Partition(data, dataIdx, leftIdx, rightIdx);
                QuickSort(ref data, ref dataIdx, leftIdx, pivotIdx - 1);
                QuickSort(ref data, ref dataIdx, pivotIdx + 1, rightIdx);
            }
        }
        #endregion

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
