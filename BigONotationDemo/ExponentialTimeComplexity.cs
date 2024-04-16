namespace BigONotationDemo
{
    // O(2^n)
    public static class ExponentialTimeComplexity
    {
        public static List<List<int>> GenerateSubsets(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            int n = nums.Length;

            // Total number of subsets is 2^n
            for (int i = 0; i < (1 << n); i++)
            {
                List<int> subset = new List<int>();

                // Construct subset based on binary representation of i
                for (int j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        subset.Add(nums[j]);
                    }
                }

                result.Add(subset);
            }

            return result;
        }
    }
}
