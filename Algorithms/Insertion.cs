using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Insertion
    {
        public static void DoInsertionSort(this int[] inputarray)
        {
            for (int i = 1; i < inputarray.Length; i++)
            {
                for (int j = i; j > 0 && inputarray[j-1]> inputarray[j]; j--)
                {
                    inputarray.SwapValuesIndices(j, j - 1);
                }
            }
        }
    }
}
