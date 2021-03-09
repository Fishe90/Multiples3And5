using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nextNum3 = 3;
            int nextNum5 = 5;
            int startNum3 = 3;
            int startNum5 = 5;

            Console.SetCursorPosition(20, 1);
            Console.Write("    Sum of Multiples BELOW 1000");
            Console.SetCursorPosition(20, 2);
            Console.Write("Multiples of 3       Multiples of 5");

            while (nextNum3 < 1000)
            {
                Console.SetCursorPosition(20, 3);
                Console.Write(startNum3);
                nextNum3 += 3;
                startNum3 += nextNum3;
                System.Threading.Thread.Sleep(1);
            }

            while (nextNum5 < 1000)
            {
                Console.SetCursorPosition(41, 3);
                Console.Write(startNum5);
                nextNum5 += 5;
                startNum5 += nextNum5;
                System.Threading.Thread.Sleep(1);
            }

            startNum3 -= nextNum3;
            startNum5 -= nextNum5;
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("Sum of multiples of 3 AND 5 BELOW 1000");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine(startNum3 + startNum5);
        }

        //Calculates the sum of Multiples BELOW the Max Multiple
        public static void SumMultiplesBELOW(int multiple, int maxMultiple)
        {
            int multiplus = multiple;
            int nextMultiple = multiple;
            while (nextMultiple < maxMultiple)
            {
                Console.SetCursorPosition(41, 8);
                Console.Write(multiple);
                nextMultiple += multiplus;
                multiple += nextMultiple;
                System.Threading.Thread.Sleep(1);
            }
        }

        //Calculates the sum of Multiples less than OR equal to the Max Multiple
        public static void SumMultiples(int multiple, int maxMultiple)
        {
            int multiplus = multiple;
            int nextMultiple = multiple;
            while (nextMultiple <= maxMultiple)
            {
                Console.SetCursorPosition(41, 9);
                Console.Write(multiple);
                nextMultiple += multiplus;
                multiple += nextMultiple;
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
