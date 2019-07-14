using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Swap
    {
        public static void SwapValuesIndices<T>(this T[] objects, int j, int i)
        {
            T temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
