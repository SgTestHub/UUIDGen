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

        [Fact]
        public void TestCase04()
        {
            var input = "923 11613 30483 19569 24201 13461 1189 30793 8848 16914 16053 21700 22116 3852 20909 5231 31469 3862 16353 22813 28735 4421 3618 32303 9932 31892 7823 22547 28888 11143 11695 3339 2094 11023 9661 27440 7186 24750 15427 24502 31606 23515 3563 29553 12145 22184 11409 28824 6636 10658 21404 5578 27807 14073 13967 31310 3132 4321 7643 1951 13289 24375 17912 11304";
            var expected = "3862 16353 22813 28735";
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCase05()
        {
            var input = "27892 18536 13491 11084 11970 24975 30922 11945 15113 27101 1974 31902 2623 21822 11720 30730 23635 27193 17527 19799 16794 30488 8953 28856 12300 25162 32016 20910 30896 6661 9255 26577 12629 10032 24221 31949 26243 26495 18785 22443 10673 13024 30655 11602 20408 28694 17785 31309 29576 23715 3866 10702 4378 3052 17543 11763 19622 24984 2519 27977 14869 2873 23140 10639 14521 15662 25122 17340 14140 14024 304 323 29654 20907 11693 13973 3267 8311 10189 31463 29941 24744 13356 18742 8454 17339 20578 12937 112 21395 5591 1399 5888 30234 16089 3816 19080 21547 491 22560 14549 10160 14176 1529 10720 13575 32041 15727 29256 29611 19692 12642 23040 10768 14422 15768 23365 206 16305 13058 19924 20738 30393 14656 21081 12785 27563 26982";
            var expected = "11084 11970 24975 30922";
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase06()
        {
            var input = "4650 2543 1184 1537 10037 9856 18201 29781 16440 8124 15835 23273 21808 2808 28925 2374 19 16546 9279 3323 19905 14701 20381 6116 6968 18094 1572 7084 21256 10758 16133 16017 7944 20546 13544 3431 25158 13183 20354 3808 3908 10386 19306 7178 11873 7079 5160 8729 10389 39 1167 12647 10849 30688 334 32185 13062 30048 8641 13252 9206 23969 23309 18416 25736 27884 24939 8795 28143 25335 13252 19489 21357 14929 1407 475 6852 28415 31383 20325 30958 6248 27120 6373 18189 23150 6635 13576 17317 29150 11064 31887 29705 24586 9707 29451 14867 31156 23762 27876 29208 23854 6918 22176 11547 5056 20417 354 23361 25162 11375 6321 31365 3370 26888 9595 7597 4960 8860 16986 24445 9456 2096 25877 5674 22664 18888 24938 23314 25699 32197 2315 15017 24173 28785 3302 8375 18344 4569 937 21697 26318 30171 14726 6852 13880 6783 11572 19498 26878 26763 24118 31990 19296 8785 20575 322 613 13516 26774 26347 28353 7915 1751 14219 14076 25389 378 5799 15569 14190 26040 4138 469 26369 8555 11026 16217 6910 31253 5226 13712 31965 29988 30328 30197 26436 5492 20535 11495 6430 4630 24840 11926 7917 27216 31908 19235 26209 31460 23381 11779 12329 30869 14950 19621 21513 29672 24791 10324 2861 18984 23638 26462 13501 10156 2667 2422 18609 32605 16883 15191 27879 7026 12495 3498 24690 11134 16861 4906 12598 29613 7975 10758 28594 330 9307 29830 21788 2181 21884 17650 4019 20340 11734 176 10577 19031 23351 16044 15423 19744 14684 9469 27214 30259";
            var expected = "3808 3908 10386 19306";
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase07()
        {
            var input = LoadTestDataFile("TestCase7_Input.txt");
            var expected = LoadTestDataFile("TestCase7_Output.txt");
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase08()
        {
            var input = LoadTestDataFile("TestCase8_Input.txt");
            var expected = LoadTestDataFile("TestCase8_Output.txt");
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase09()
        {
            var input = LoadTestDataFile("TestCase9_Input.txt");
            var expected = LoadTestDataFile("TestCase9_Output.txt");
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase10()
        {
            var input = "6 2 4 6 1 5 9 2";
            var expected = "2 4 6";
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCase11()
        {
            var input = "6 2 4 3 1 5 9";
            var expected = "1 5 9";
            var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
            Assert.Equal(expected, result);
        }
    }
}
