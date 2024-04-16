namespace BigONotationDemo
{
    // O(n!)
    public static class FactorialTimeComplexity
    {
        // This algorithm generates all possible permutations (a rearrangement of the elements of a set into a specific order) of the given array nums.
        // The time complexity of this algorithm is O(n!), where n is the number of elements in the input array.
        // As the size of the array increases, the number of permutations grows factorially, resulting in an exponential increase in the number of recursive calls and overall execution time.
        public static void GeneratePermutations(int n, int[] nums, List<List<int>> result)
        {
            if (n == 1)
            {
                List<int> permutation = new List<int>(nums);
                result.Add(permutation);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    GeneratePermutations(n - 1, nums, result);
                    if (n % 2 == 0)  // For even 'n', swap nums[i] with nums[n-1]
                    {
                        Swap(nums, i, n - 1);
                    }
                    else  // For odd 'n', always swap nums[0] with nums[n-1]
                    {
                        Swap(nums, 0, n - 1);
                    }
                }
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}