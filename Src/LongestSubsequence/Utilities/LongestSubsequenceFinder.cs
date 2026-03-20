using System.Diagnostics;

namespace Utilities
{
    public class LongestSubsequenceFinder
    {
        public static string FindLongestSubsequence(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Input cannot be empty or whitespace.");
            }
            var numbers = ConvertToIntArray(input);
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Input must contain at least one integer.", nameof(input));
            }
            if (numbers.Length == 1)
            {
                return numbers[0].ToString();
            }

            var (start, length) = GetLongestRunIndex(numbers);

            //Console.WriteLine($"Longest run starts at index {start} with length {length}.");
            //return string.Concat(numbers.Select(x => x.ToString() + " ")).TrimEnd();

            return FormatOutput(numbers, start, length); ;
        }


        internal static int[] ConvertToIntArray(string input)
        {
            var parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out result[i]))
                {
                    throw new ArgumentException($"Invalid integer value: '{parts[i]}'", nameof(input));
                }
            }
            return result;

        }

        internal static string FormatOutput(int[] nums, int start, int length)
        {
            var parts = new string[length];

            for (var i = 0; i < length; i++)
            {
                parts[i] = nums[start + i].ToString();
            }

            return string.Join(" ", parts);
        }

        //using the two pointer technique to find the longest run of increasing integers in the array
        internal static (int Start, int Length) GetLongestRunIndex(int[] nums)
        {
            var startPointer = 0;
            var endPointer = 1;
            var currentStart = 0;
            var currentLength = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > endPointer)
                    {
                        endPointer = currentLength;
                        startPointer = currentStart;
                    }

                    currentStart = i;
                    currentLength = 1;
                }
            }

            // Check the final run
            if (currentLength > endPointer)
            {
                endPointer = currentLength;
                startPointer = currentStart;
            }

            return (startPointer, endPointer);
        }
    }
}
