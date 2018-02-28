using System;
using System.Collections.Generic;

namespace sorttest
{
    class Program
    {
        static void Main(string[] args)
        {
      
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
            List<string> myList = new List<string>(context);
            myList.Sort(new StringComparer());

            Console.WriteLine("There is " + context.Length + " lines");

            foreach (var s in myList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
