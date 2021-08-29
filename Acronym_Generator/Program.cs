using System;
using System.Text;

namespace Acronym_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(generateAcronym("Portable Network Graphics"));
            Console.WriteLine(generateAcronym("First In, First Out"));
            Console.WriteLine(generateAcronym("Asynchronous JavaScript and XML"));
            Console.WriteLine(generateAcronym("GNU Image Manipulation Program"));
            Console.WriteLine(generateAcronym("Complementary metal-oxide semiconductor"));
            Console.WriteLine(generateAcronym("Something - I made up from thin air"));
        }

        public static string generateAcronym (string input)
        {

            string[] words = input.ToUpper().Split(' ');
            StringBuilder str = new StringBuilder();

            foreach (var word in words)
            {
                
                    if (word.Contains("-")) //hyphenated words are exceptional
                    {
                        string[] hyphenatedWords = word.Split("-");

                        foreach (var wordSegment in hyphenatedWords)
                        {
                            if (wordSegment.Length > 0) //ignore "" 
                            {
                                var c = wordSegment[0];
                                if ((c >= 'A' && c <= 'Z')) //we only want the alphabet
                                {
                                    str.Append(c);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (word.Length > 0) 
                        {
                            var c = word[0];
                            if ((c >= 'A' && c <= 'Z')) 
                            {
                            str.Append(c);
                            }
                        }
                }
            }

            return str.ToString(); 
        }
    }
}
