using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Invalid args!");
                return;
            }

            var command = args[0].ToLower();

            switch (command)
            {
                case "quicksort":
                    Quicksort(GenerateList(int.Parse(args[1])));
                    return;
                case "bubblesort":
                    Bubblesort(GenerateList(int.Parse(args[1])));
                    return;
            }

            //Heapsort --> https://de.wikipedia.org/wiki/Heapsort

            //Radixsort --> https://de.wikipedia.org/wiki/Radixsort

            //selectionsort --> https://de.wikipedia.org/wiki/Selectionsort

            //insertionsort --> https://de.wikipedia.org/wiki/Insertionsort

            //gnomesort --> https://de.wikipedia.org/wiki/Gnomesort


            Console.ReadLine();
        }

        private static void Bubblesort(int[] input)
        {
            var stopwatch = new Stopwatch();

            //Bubblesort --> https://de.wikipedia.org/wiki/Bubblesort
            Console.WriteLine("--------------------Bubblesort-----------------------");

            var bubbleSorter = new BubbleSort();
            //Console.WriteLine("Unsorted List: " + ArrayToString(unsortedArray));

            stopwatch.Start();
            var sortedList = bubbleSorter.Sort(input);
            stopwatch.Stop();

            //Console.WriteLine("Sorted List: " + ArrayToString(sortedList));
            Console.WriteLine("Time: " + stopwatch.Elapsed.ToString());
        }

        private static void Quicksort(int[] input)
        {
            var stopwatch = new Stopwatch();

            //Quicksort --> https://de.wikipedia.org/wiki/Quicksort
            Console.WriteLine("--------------------Quicksort-----------------------");

            var quickSorter = new Quicksort();
            //Console.WriteLine("Unsorted List: " + ArrayToString(unsortedArray));

            stopwatch.Start();
            var sortedList = quickSorter.Sort(input);
            stopwatch.Stop();

            //Console.WriteLine("Sorted List: " + ArrayToString(sortedList));
            Console.WriteLine("Time: " + stopwatch.Elapsed.ToString());
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
