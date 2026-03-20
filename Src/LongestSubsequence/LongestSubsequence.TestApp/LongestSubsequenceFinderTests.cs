using Utilities;
namespace LongestSubsequence.TestApp
{
    public class LongestSubsequenceFinderTests
    {
        private static string LoadTestDataFile(string filename)
        {
            var path = Path.GetFullPath(Path.Combine("..", "..", "..", "TestFiles", filename));
            return File.ReadAllText(path).Trim();
        }

        [Fact]
        public void TestCase01()
        {
            var input = "6 1 5 9 2";
            var expected = "1 5 9";
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase02()
        {
            var input = LoadTestDataFile("TestCase2_Input.txt");
            var expected = LoadTestDataFile("TestCase2_Output.txt");
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase03()
        {
            var input = LoadTestDataFile("TestCase3_Input.txt");
            var expected = LoadTestDataFile("TestCase3_Output.txt");
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }

    }
}
