using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int integer = int.Parse(Console.ReadLine());

            if(integer % 15 == 0)
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if(integer % 3 == 0)
            {
                Console.WriteLine("FIZZ");
            }
            else if(integer % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 or 5.");
            }
        }
    }
}
