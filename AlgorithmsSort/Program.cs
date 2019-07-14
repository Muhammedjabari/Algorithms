using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using System.IO;
using System.Diagnostics;

namespace AlgorithmsSort
{
    class Program
    {
        //public static void Main(string[] args)
        //{
        //    Shell();
        //    Console.ReadKey();
        //}

        public static int[] nums = new int[] { 1499, 2999 };
        public static int[] csv;
        public static int[] sData;
        public int numb = 0;
        public static int[] Fnum = new int[] { };
        static void Main(string[] args)
        {
            using (var read = new StreamReader (@"C:\Users\Muham\Desktop\New folder\Algorithms\unsorted_numbers.csv"))
            {
                csv = read.ReadToEnd().Split('\n').SelectMany(s => s.Split(',').Select(x => int.Parse(x))).ToArray<int>();
                sData = csv;
                int n = csv.Length;
                int f = sData.Length;

                Console.WriteLine("Shell Sorting.");
                Stopwatch stopwatch1 = new Stopwatch();
                stopwatch1.Start();                    
                stopwatch1.Stop();
                TimeSpan timeSpan = stopwatch1.Elapsed;
                Console.WriteLine($"Shell Sort took is: {timeSpan.TotalMilliseconds} Milliseconds");
                Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Insertion Sorting");
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();           
                stopwatch2.Stop();
                TimeSpan timeSpan2 = stopwatch2.Elapsed;              
                Console.WriteLine($"Insertion Sort took: {timeSpan2.TotalMilliseconds} Milliseconds");
                Console.WriteLine();
                Console.ReadLine();

                Console.WriteLine("Linear Searching");
                Stopwatch stopwatch3 = new Stopwatch();
                stopwatch3.Start();
                LinearSearch(csv);
                stopwatch3.Stop();
                TimeSpan timeSpan3 = stopwatch3.Elapsed;
                Console.WriteLine($"Linear Search took: {timeSpan3.TotalMilliseconds} Milliseconds");
                Console.ReadLine();



                Console.WriteLine("Binary Searching");
                Stopwatch stopwatch4 = new Stopwatch();
                stopwatch4.Start();
                BinarySearch(csv);
                TimeSpan timeSpan4 = stopwatch4.Elapsed;
                Console.WriteLine($"Binary Search took: {timeSpan4.TotalMilliseconds} Milliseconds");
                Console.ReadLine();
            }
        }

            //string[] readAllLines = File.ReadAllLines(path);
            //int[] inputNumbers = Array.ConvertAll(readAllLines, int.Parse);
            //foreach (int line in inputNumbers)
            //{
            //    Console.WriteLine(line);
            //}
            //return inputNumbers;
        //}
        
        public static int[] Shell(int[] arr, int x)
        {
            int i, j, position, temp;
            position = 3;
            while (position > 0)
            {
                for (i = 0; i < x; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= position) && (arr[j - position] > temp))
                    {
                        arr[j] = arr[j - position];
                        j = j - position;
                    }
                    arr[j] = temp;
                }
                if (position / 2 != 0)
                    position = position / 2;
                else if (position == 1)
                    position = 0;
                else
                    position = 1;
            }
            return arr;
        }
        public static int[] InsertionSort(int[] arr)
        {
            //int[] inputarray = ReadFile();
            //inputarray.DoInsertionSort();

            //foreach (int inputarrays in inputarray)
            //    Console.WriteLine(inputarrays + " ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        Console.WriteLine(arr[j]);
                    }
                }
            }
            return arr;
        }
        public static object BinarySearch(int[] arr)
        {
            bool loop = true;
            int arLength = arr.Length;
            int i = 1499;
            int Start = 0;
            int End = arr.Length - 1;
            int Middle = (Start + End) / 2;

        loopBefore:
            while (loop)
            {

                arLength = arr.Length;
                Start = 0;
                End = arr.Length - 1;
                Middle = (Start + End) / 2;


            loopAfter:
                while (true)
                {

                    if (Middle == i)
                    {
                        Console.WriteLine(arr[i]);
                        break;
                    }
                    else if (i < Middle)
                    {
                        End = Middle;
                        Middle = (Start + End) / 2;
                        goto loopAfter;
                    }
                    else
                    {
                        Start = Middle;
                        Middle = (Start + End) / 2;

                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine(arr[i]);
                            loop = false;
                            goto loopBefore;
                        }
                        goto loopAfter;
                    }
                }
                if (i == 14999)
                {
                    loop = false;
                }
                i = i + 1500;
            }
            return -1;
        }
        public static int LinearSearch(int[] arr)
        {
            int Max = arr.Length + 1;

            for (int i = 1; i < Max; i++)
            {
                if (i % 1500 == 0)
                {
                    Console.WriteLine(arr[i - 1]);
                }

            }
            return -1;
        }
    }
}
