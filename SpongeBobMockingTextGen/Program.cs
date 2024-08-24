using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace SpongebobMockingTextGen
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
           if (args.Contains("-f"))
           {
             FileTextConversion();
           } else
           {
            CmdTextConversion();
           }
        }

        private static void CmdTextConversion()
        {
            Console.WriteLine("Please enter the text:");
            string? input = Console.ReadLine();
            string? result = ConvertToMockingText(input);
            Console.WriteLine(result);
        }

        private static void FileTextConversion()
        {   
            Console.WriteLine("please enter the path");
            string? path = Console.ReadLine();
            Console.WriteLine("reading text...");
            string? input = "";
            try
            {
                #pragma warning disable CS8604 // Possible null reference argument.
                StreamReader reader = new(path);
                #pragma warning restore CS8604 // Possible null reference argument.
                input = reader.ReadToEnd();
                reader.Close();
                
            }
            catch (Exception e)
            {
                HandleExeption(e);
                return;
            }

            string? result = ConvertToMockingText(input);
            Console.WriteLine(result);
        }

        private static void HandleExeption(Exception e)
        {
            switch (e)
            {
                case FileNotFoundException:
                    Console.WriteLine("the file was not found");
                    break;
                case OutOfMemoryException:
                    Console.WriteLine("Ran out of memory");
                    break;
                case IOException:
                    Console.WriteLine(e);
                    break;
            }
        }

        internal static string? ConvertToMockingText(string? input)
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