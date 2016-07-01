namespace BinarySearchKata
{
    public static class BinarySearch
    {
        public static int SearchForKeyReturnIndex(int key, int[] array)
        {
            int low = 0, high = (array.Length - 1), midPoint = 0;

            while (low <= high)
            {
                midPoint = (low + high) / 2;
                if (array[midPoint] == key)
                    return midPoint;
                if (key < array[midPoint])
                    high = midPoint - 1;
                else
                    low = midPoint + 1;
            }
            return -1;
        }
    }
}
