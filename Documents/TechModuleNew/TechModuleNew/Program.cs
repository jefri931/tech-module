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
<<<<<<< HEAD
            Console.WriteLine("Say something back");
            words = Console.ReadLine().ToLower();
            if(words.Contains("nice to")){
                Console.WriteLine("How are you?");
            }else if(words.Contains("how are you")){
                Console.WriteLine("fine and you?");
            }else if(words.Contains("what is your")){
                Console.WriteLine("Daniel.");
            }else if(words.Contains("you")){
                Console.WriteLine("Splendid");
            }

=======
            string nnnn = "hh";
>>>>>>> 4620a35a228226c9666f9b7e4cf5fe4d06bffb5e
        }
    }
}
