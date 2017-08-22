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
            //Ask user for an integer. If it's divisible by 3, write FIZZ. If it's divisible by 5, write BUZZ
            //If it's divisible by both 3 and 5, write FIZZBUZZ

            Console.WriteLine("Please enter an integer:");
            int integer = int.Parse(Console.ReadLine());

            if(integer % 15 == 0) //15 takes care of both 3 and 5 but can write each mod separately with &&
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
