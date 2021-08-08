using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bubblesort --> https://de.wikipedia.org/wiki/Bubblesort
            Console.WriteLine("--------------------Bubblesort-----------------------");
           
            var stopwatch = new Stopwatch();
            var bubbleSorter = new BubbleSort();
            var unsortedArray = GenerateList(50000);
            
            //Console.WriteLine("Unsorted List: " + ArrayToString(unsortedArray));
            
            stopwatch.Start();
            var sortedList = bubbleSorter.Sort(unsortedArray);
            stopwatch.Stop();

            //Console.WriteLine("Sorted List: " + ArrayToString(sortedList));
            Console.WriteLine("Time: " + stopwatch.Elapsed.ToString());

            //Quicksort --> https://de.wikipedia.org/wiki/Quicksort
            var quickSorter = new Quicksort();
            //Console.WriteLine("Unsorted List: " + ArrayToString(unsortedArray));

            stopwatch.Start();
            sortedList = quickSorter.Sort(unsortedArray);
            stopwatch.Stop();

            //Console.WriteLine("Sorted List: " + ArrayToString(sortedList));
            Console.WriteLine("Time: " + stopwatch.Elapsed.ToString());

            //Heapsort --> https://de.wikipedia.org/wiki/Heapsort

            //Radixsort --> https://de.wikipedia.org/wiki/Radixsort

            //selectionsort --> https://de.wikipedia.org/wiki/Selectionsort

            //insertionsort --> https://de.wikipedia.org/wiki/Insertionsort

            //gnomesort --> https://de.wikipedia.org/wiki/Gnomesort


            Console.ReadLine();
        }


        private static int[] GenerateList(int length, int min = 0, int max = 100)
        {
            var array = new int[length];

            var rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max);
            }

            return array;
        }

        private static string ArrayToString(int[] input)
        {
            var output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                output += input[i].ToString() + ", ";
            }

            return output;
        }

    }
}
