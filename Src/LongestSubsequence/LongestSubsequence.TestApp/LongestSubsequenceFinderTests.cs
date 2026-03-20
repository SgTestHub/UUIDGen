using Utilities;
namespace LongestSubsequence.TestApp
{
    public class LongestSubsequenceFinderTests
    {
        private static string LoadTestData()
        {
            return "5 2 3 4 5 8 4 7 6";
        }

        [Fact]
        public void TestCase01_SimpleSequenceOfInteger()
        {
            var input = "6 1 5 9 2";
            var expected = "1 5 9";
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }


    }
}
