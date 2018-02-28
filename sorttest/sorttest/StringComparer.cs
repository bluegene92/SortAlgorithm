using System;
using System.Collections.Generic;
using System.Text;

namespace sorttest
{
    class StringComparer : Comparer<string>
    {

        public static Dictionary<char, int> charValueDictionary = new Dictionary<char, int>();

        public StringComparer()
        {
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
        }

        public override int Compare(string s1, string s2)
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
