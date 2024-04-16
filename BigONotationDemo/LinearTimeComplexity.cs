namespace BigONotationDemo
{
    // O(n)
    public static class LinearTimeComplexity
    {
        // Linear Search is an algorithm that traverses the entire array or list sequentially to find a target element.
        // In the worst-case scenario, the target element may be the last element in the array, or it may not be present at all, requiring the algorithm to iterate through all elements.
        // As the size of the input data (n) increases, the algorithm needs to perform a proportionate number of comparisons to find the target element.
        // Therefore, the time complexity of Linear Search is O(n), as the number of comparisons grows linearly with the size of the input data.
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }

            return -1; // Element not found
        }

        // This algorithm iterates through each element of the array sequentially.
        // For each element, it checks if it matches the target element and increments a counter accordingly.
        // In the worst-case scenario, where all elements in the array are the target element, the algorithm needs to traverse the entire array.
        // As the size of the input data (n) increases, the algorithm performs a proportionate number of comparisons and increments the counter for each occurrence.
        // Therefore, the time complexity of the Count Occurrence algorithm is also O(n), as it requires linear time to process each element in the input data.
        public static int CountOccurrence(int[] arr, int target)
        {
            int count = 0;

            foreach (int num in arr)
            {
                if (num == target)
                    count++;
            }

            return count;
        }
    }
}