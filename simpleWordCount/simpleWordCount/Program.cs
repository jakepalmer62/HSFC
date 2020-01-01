using System;

namespace simpleWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
             public static class WordCount
        {
            public static int Count(string x)
            {
                int result = 0;

                //Trim whitespace from beginning and end of string
                x = x.Trim();

                //Necessary because foreach will execute once with empty string returning 1
                if (x == "")
                    return 0;

                //Ensure there is only one space between each word in the passed string
                while (x.Contains("  "))
                    x = x.Replace("  ", " ");

                //Count the words
                foreach (string y in x.Split(' '))
                    result++;

                return result;
            }
    }
}
