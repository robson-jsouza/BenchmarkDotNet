using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkDotNetPOC.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        private const string DateTime = "2023-03-05T17:56:15Z";
        private static readonly DateParser Parser = new DateParser();

        [Benchmark(Baseline = true)]    // this is where everything started, the base implementation to be compared, after this, code will be optimized
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTime);
        }

        [Benchmark]
        public void GetYearFromSplit()
        {
            Parser.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            Parser.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            Parser.GetYearFromSpan(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpanWithManualConversion()
        {
            Parser.GetYearFromSpanWithManualConversion(DateTime);
        }
    }
}
