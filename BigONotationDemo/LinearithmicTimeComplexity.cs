namespace BigONotationDemo
{
    // O(n log n)
    public static class LinearithmicTimeComplexity
    {
        public static void MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[array.Length - mid];

            // Copy elements to left and right arrays
            Array.Copy(array, 0, leftArray, 0, mid);
            Array.Copy(array, mid, rightArray, 0, array.Length - mid);

            // Recursively sort left and right arrays
            MergeSort(leftArray);
            MergeSort(rightArray);

            // Merge sorted arrays
            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            // Compare elements from left and right arrays and merge them into result array
            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                    array[resultIndex++] = leftArray[leftIndex++];
                else
                    array[resultIndex++] = rightArray[rightIndex++];
            }

            // Copy remaining elements from left array, if any
            while (leftIndex < leftArray.Length)
                array[resultIndex++] = leftArray[leftIndex++];

            // Copy remaining elements from right array, if any
            while (rightIndex < rightArray.Length)
                array[resultIndex++] = rightArray[rightIndex++];
        }
    }
}