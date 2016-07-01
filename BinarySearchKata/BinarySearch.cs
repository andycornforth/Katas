using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchKata
{
    public class BinarySearch
    {
        public int SearchFor(int key, int[] array)
        {
            if (array.Length.Equals(0) || !array.Contains(key))
                return 0;

            int low = 0, high = (array.Length - 1), iterations = 0, midPoint = 0;

            do
            {
                midPoint = (low + high) / 2;
                if (key < array[midPoint])
                    high = midPoint - 1;
                else
                    low = midPoint + 1;
                iterations++;
            } while (array[midPoint] != key);

            return iterations;
        }
    }
}
