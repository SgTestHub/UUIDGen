using Utilities;

Console.Write("Enter integers separated by spaces: ");
var input = Console.ReadLine();

var result = LongestSubsequenceFinder.FindLongestSubsequence(input);
Console.WriteLine($"Output: {result}");

