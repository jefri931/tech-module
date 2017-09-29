using System;

namespace TechModuleNew
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string words = Console.ReadLine();
            string first = words[0].ToString().ToUpper();
            first =first + words.Substring(1,words.Length-1);
            Console.WriteLine("Hello " + first+", nice to meet you.");
            string hello = "hll";

        }
    }
}
