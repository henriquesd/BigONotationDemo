namespace BigONotationDemo
{
    // O(1)
    public static class ConstantTimeComplexity
    {
        // Regardless of the size of the array, accessing a specific element by its index takes constant time.
        public static int GetArrayValueByIndex(int[] array, int index)
        {
            return array[index];
        }

        // This method performs a single operation (the modulo operation %) and a comparison (==),
        // both of which take constant time to execute, regardless of the size of the number.
        public static bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }
    }
}