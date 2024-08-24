using System.Text;

namespace SpongebobMockingTextGen
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text:");
            string input = Console.ReadLine();
            string result = ConvertToMockingText(input);
            Console.WriteLine(result);
        }

        internal static string ConvertToMockingText(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder result = new StringBuilder(input.Length);
            bool makeUpperCase = false;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    result.Append(makeUpperCase ? char.ToUpper(c) : char.ToLower(c));
                    makeUpperCase = !makeUpperCase;
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}