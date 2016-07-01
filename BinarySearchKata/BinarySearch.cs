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
            if (array.Length.Equals(0))
                return 0;
            if (!array.Contains(key))
                return -1;
            if (array.Length.Equals(1))
                return 1;


            int low = 0, high = (array.Length - 1);

            var midPoint = (low + high) / 2;
            int iterations = 1;
            int currentValue = array[midPoint];

            while (currentValue != key)
            {
                if (currentValue > key)//lower half
                {
                    high = midPoint - 1;
                }
                else//higher half
                {
                    low = midPoint + 1;
                }
                midPoint = (low + high) / 2;
                currentValue = array[midPoint];
                iterations++;
            }

            return iterations;
        }
    }
}
