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
            string result = string.Concat(numbers.Select(x => x.ToString() + " ")).TrimEnd();
            return result;
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
    }
}
