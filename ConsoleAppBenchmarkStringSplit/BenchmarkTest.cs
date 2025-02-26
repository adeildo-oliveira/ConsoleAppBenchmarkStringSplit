using BenchmarkDotNet.Attributes;

namespace ConsoleAppBenchmarkStringSplit
{
    [MemoryDiagnoser]
    public class BenchmarkTest
    {
        [Benchmark]
        public string SplitWithSpan()
        {
            return ExtractWithSplit.SplitWithSpan($"987_{Guid.NewGuid()}");
        }

        [Benchmark]
        public string SplitWithString()
        {
            return ExtractWithSplit.SplitWithString($"987_{Guid.NewGuid()}");
        }
    }
}
