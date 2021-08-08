using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class BubbleSort: ISortingAlgorithm
    {
        public int[] Sort(int[] input)
        {
            int changeCount = 2;
            while (changeCount != 0)
            {
                changeCount = 0;

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if(input[i] > input[i + 1])
                    {
                        changeCount++;
                        
                        var a = input[i];
                        var b = input[i + 1];

                        input[i] = b;
                        input[i+1] = a;

                    }
                }
            }

            return input;
        }
    }
}
