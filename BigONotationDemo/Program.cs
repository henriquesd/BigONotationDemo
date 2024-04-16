using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using BigONotationDemo;

BenchmarkRunner.Run<BigONotationProgram>();

namespace BigONotationDemo
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [MarkdownExporter]
    public class BigONotationProgram
    {
        #region Fields
        readonly int[] arrayGetArrayValueByIndex = Enumerable.Range(0, 10_000).Select(_ => new Random().Next()).ToArray();
        readonly int arrayIndex = 7_408;

        readonly int[] arrayBinarySearch = Enumerable.Range(0, 10_000).Select(_ => new Random().Next()).ToArray();
        readonly int targetBinarySearch = 7_408;

        readonly int[] arrayLinearSearch = Enumerable.Range(0, 10_000).Select(_ => new Random().Next()).ToArray();
        readonly int targetLinearSearch = 7_408;

        readonly int[] arrayMergeSort = Enumerable.Range(0, 10_000).Select(_ => new Random().Next()).ToArray();

        readonly int[] arrayBubbleSort = Enumerable.Range(0, 10_000).Select(_ => new Random().Next()).ToArray();

        readonly int[] numsSubSets = Enumerable.Range(0, 10_000).Select(_ => new Random().Next()).ToArray();
        #endregion

        [Benchmark(Description = "O(1) - Get Array value by Index")]
        public void RunGetArrayValueByIndex()
        {
            ConstantTimeComplexity.GetArrayValueByIndex(arrayGetArrayValueByIndex, arrayIndex);
        }

        [Benchmark(Description = "O(log n) - Binary Search")]
        public void BinarySearch()
        {
            LogarithmicTimeComplexity.BinarySearch(arrayBinarySearch, targetBinarySearch);
        }

        [Benchmark(Description = "O(n) - Linear Search")]
        public void LinearSearch()
        {
            LinearTimeComplexity.LinearSearch(arrayLinearSearch, targetLinearSearch);
        }

        [Benchmark(Description = "O(n log n) - Merge Sort")]
        public void MergeSort()
        {
            LinearithmicTimeComplexity.MergeSort(arrayMergeSort);
        }

        [Benchmark(Description = "O(n^2) - Bubble Sort")]
        public void BubbleSort()
        {
            QuadraticTimeComplexity.BubbleSort(arrayBubbleSort);
        }

        [Benchmark(Description = "O(2^n) - Generate Subsets")]
        public void GenerateSubsets()
        {
            ExponentialTimeComplexity.GenerateSubsets(numsSubSets);
        }
    }
}