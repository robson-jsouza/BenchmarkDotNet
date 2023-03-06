using BenchmarkDotNetPOC;

namespace BenchmarkDotNetPOCTests
{
    [TestClass]
    public class DateParserTests
    {
        private const string dateTime = "2023-03-05T17:56:15Z";
        private readonly int year;
        private readonly DateParser dateParser = new DateParser();

        public DateParserTests()
        {
            year = int.Parse(dateTime.Substring(0, 4));
        }

        [TestMethod]
        public void GetYearFromDateTimeTest()
        {
            var result = dateParser.GetYearFromDateTime(dateTime);
            Assert.AreEqual(result, year);
        }

        [TestMethod]
        public void GetYearFromSplitTest()
        {
            var result = dateParser.GetYearFromSplit(dateTime);
            Assert.AreEqual(result, year);
        }

        [TestMethod]
        public void GetYearFromSubstringTest()
        {
            var result = dateParser.GetYearFromSubstring(dateTime);
            Assert.AreEqual(result, year);
        }

        [TestMethod]
        public void GetYearFromSpanTest()
        {
            var result = dateParser.GetYearFromSpan(dateTime);
            Assert.AreEqual(result, year);
        }

        [TestMethod]
        public void GetYearFromSpanWithManualConversionTest()
        {
            var result = dateParser.GetYearFromSpanWithManualConversion(dateTime);
            Assert.AreEqual(result, year);
        }
    }
}