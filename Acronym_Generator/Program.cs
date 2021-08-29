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

            //DESIRED OUTPUT: PNG, FIFO, AJAX, GIMP, CMOS, SIMUFTA

        }

        public static string generateAcronym (string input)
        {

            string[] words = input.ToUpper().Split(' '); //acronyms are caps anyway so let's do that now
            StringBuilder acronym = new StringBuilder();

            foreach (var word in words)
            {
                
                    if (word.Contains("-")) //hyphenated words are exceptional so check for the hyphen first
                    {
                        string[] hyphenatedWords = word.Split("-");

                        foreach (var wordSegment in hyphenatedWords)
                        {
                            addFirstCharToAcronym(wordSegment, acronym); 
                        }

                    }
                    else
                    {
                        addFirstCharToAcronym(word, acronym);
                    }

            }

            return acronym.ToString();

        }

        public static void addFirstCharToAcronym(string word, StringBuilder str) //return is void because we're passing in ref to the StringBuilder
        {
            if (word.Length > 0) //ignore ""
            {
                var c = word[0]; 

                if ((c >= 'A' && c <= 'Z')) //we only want the alphabet
                {
                    str.Append(c);
                }
            }
        }


    }
}
