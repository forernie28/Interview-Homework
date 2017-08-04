using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Print numbers from 1 to 100 if divisible by 3 print fizz instead of number, 
            //if divisible by 5 print buzz instead.

                Homework();

        }
            //Homework move into method (function) to be recalled in public program. Upload to github.
        public static void Homework()
        {
        int i = 1;

            for (i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0 && i % 5 == 0))
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                { 
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
