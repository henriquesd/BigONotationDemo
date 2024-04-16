namespace BigONotationDemo
{
    // O(n^2)
    public static class QuadraticTimeComplexity
    {
        // In the worst case, Bubble Sort compares each element of the array with every other element,
        // resulting in n * n comparisons, where n is the number of elements in the array.
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Selection Sort divides the array into two parts: sorted and unsorted.
        // In each iteration, it finds the minimum element from the unsorted part and moves it to the sorted part.
        // This involves n + (n-1) + (n-2) + ... + 1 = n * (n+1) / 2 comparisons, resulting in O(n²) time complexity.
        public static void SelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}