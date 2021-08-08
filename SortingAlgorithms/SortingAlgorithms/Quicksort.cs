using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Quicksort : ISortingAlgorithm
    {
        private int[] data;

        public int[] Sort(int[] input)
        {
            data = input;

            Quicksorter(0, input.Length - 1);

            return data;
        }

        private void Quicksorter(int left, int right)
        {
            if(left < right)
            {
                var pivot = Partitioning(left, right);
                Quicksorter(left, pivot - 1);
                Quicksorter(pivot + 1, right);
            }
        }

        private int Partitioning(int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = data[right];

            while(i < j)
            {
                while (i < right && data[i] < pivot)
                {
                    i++;
                }

                while (j > left && data[j] >= pivot)
                {
                    j--;
                }

                if(i < j)
                {
                    var a = data[i];
                    var b = data[j];

                    data[j] = a;
                    data[i] = b;
                }
            }

            if (data[i] > pivot)
            {
                var a = data[i];
                var b = data[right];

                data[right] = a;
                data[i] = b;
            }

            return i;
        }

    }
}
