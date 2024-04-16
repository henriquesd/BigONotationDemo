namespace BigONotationDemo
{
    // O(log n)
    public static class LogarithmicTimeComplexity
    {
       // This algorithm has a time complexity of O(log n) because it halves the search space in each iteration of the while loop.
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                if (arr[mid] == target)
                {
                    return mid;
                }

                // If target greater, ignore left half
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else // If target is smaller, ignore right half
                {
                    right = mid - 1;
                }
            }

            // Return -1 if element was not present
            return -1;
        }
    }
}