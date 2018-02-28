using System;
using System.Collections.Generic;

namespace sorttest
{
    class Program
    {
        public static Dictionary<char, int> charValueDictionary = new Dictionary<char, int>();

        static void Main(string[] args)
        {

            //Dictionary<char, int> charValueDictionary = new Dictionary<char, int>();

            int startValue = 0;
            for (char lowercaseLetter = 'a', 
                    uppercaseLetter = 'A'; 
                    uppercaseLetter <= 'Z';)
            {
                charValueDictionary.Add(lowercaseLetter, startValue++);
                charValueDictionary.Add(uppercaseLetter, startValue++);
                lowercaseLetter++;
                uppercaseLetter++;
            }

            charValueDictionary.Add(' ', 52);

            foreach (KeyValuePair<char, int> kvp in charValueDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            string[] context = new string[] {
                "Software Architecture and Design",
                "Architecture and Design Software",
                "and Design Software Architecture",
                "Design Software Architecture and",
                "aA aaa",
                "aaa aA",
                "aa Aaa",
                "Aaa aa",
                "Aa Aaa",
                "Aaa Aa",
                "AA aaa",
                "aaa AA",
                "University of Central Oklahoma",
                "of Central Oklahoma University",
                "Central Oklahoma University of",
                "Oklahoma University of Central",
                "univ of central OK",
                "of central OK univ",
                "central OK univ of",
                "OK univ of central"
            };

            Console.WriteLine("There is " + context.Length + " lines");

            Array.Sort(context, SortByAlphabet);

            for (int i = 0; i < context.Length; ++i)
            {
                Console.WriteLine(context[i]);
            }
        }

        public static int SortByAlphabet(string s1, string s2)
        {
            int charCount = Math.Min(s1.Length, s2.Length);
            Console.WriteLine("The shorter string is: " + charCount);
            for (int i = 0; i < charCount; ++i)
            {
                int v1 = charValueDictionary[s1[i]];
                int v2 = charValueDictionary[s2[i]];
                Console.WriteLine("The value of " + s1[i] + " is " + v1);
                Console.WriteLine("The value of " + s2[i] + " is " + v2);
                Console.WriteLine();

                if (v1 == v2) continue;

                if (v1 < v2) return -1;
                else if (v1 > v2) return 1;
                
            }
            return 0;
        }


    }
}
