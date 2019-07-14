using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms
{
    public static class Read
    {
        public static int[] ReadFile()
        {
            string path = @"C:\users\101668629\source\repos\Algorithms\AlgorithmsSort\unsorted_numbers.csv";

            string[] readAllLines = File.ReadAllLines(path);
            int[] inputNumbers = Array.ConvertAll(readAllLines, int.Parse);
            foreach (int line in inputNumbers)
            {
                Console.WriteLine(line);
            }
            return inputNumbers;
        }
    }
}
