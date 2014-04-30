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
            int n;
            string o;
            Console.Write("Enter a number:");
            o = Console.ReadLine();
            n = Convert.ToInt32(o);
            Console.Write("W");
            for (int i = 0; i < n; i++)
            {
                Console.Write("o");
            }
            {
                Console.Write("W!");
            }



        }
       
    }
}
