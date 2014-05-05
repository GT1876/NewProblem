using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool a = true;
                Console.Write("Enter a word:");
                string word = Console.ReadLine().ToLower();
                if (word == "quit")
                    break;

                //Print out if word is pallindrome

                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        a = false;
                    }
                }

                if (a)
                {
                    Console.WriteLine("Yasssss");
                }
                else
                {
                    Console.WriteLine("Nooooooo");
                }

            }
        }
    }
}