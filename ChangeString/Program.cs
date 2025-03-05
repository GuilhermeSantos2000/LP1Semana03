using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Type a string: ");
            string phrase = Console.ReadLine();

            Console.Write("Type a letter to be replaced: ");
            string letter = Console.ReadLine();
            char SingleLetter = char.Parse(letter);

            foreach (char i in phrase)
            {
                if (i == SingleLetter)
                {
                Console.Write("x");
                }
                else 
                {
                Console.Write(i);
                }
            }            
        }
    }
}