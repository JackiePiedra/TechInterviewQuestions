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

            if (integer % 15 == 0) //15 takes care of both 3 and 5 but can write each mod separately with &&
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if (integer % 3 == 0)
            {
                Console.WriteLine("FIZZ");
            }
            else if (integer % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 or 5.");
            }

            //print out all prime numbers than are less than 100 to console
            //List<int> totalNums = new List<int>();
            List<int> primeNums = new List<int>() { 2, 3, 5, 7 };
            int maxNum = 100;
            for (int i = 2; i <= maxNum; i++)
            {
                primeNums.Add(i);
            }

            for (int i = 2; i <= maxNum; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    primeNums.Remove(i);
                    //primeNums.Add(i);
                }
            }

            foreach (int num in primeNums)
            {
                Console.WriteLine(num);
            }

            //bool isPrime = true;
            //for (int i = 2; i <= 100; i++)
            //{
            //    for (int j = 2; j <= 100; j++)
            //    {
            //        if (i != j && i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //}
            //if(isPrime)
            //{
            //    Console.WriteLine(i +" ");
            //}
            //isPrime = true;


            //create a method that takes one int Array
            //the method should return the largest # in that array
            int[] randomNums = { 6, 4, 8, 2 };
            Console.WriteLine(FindLargest(randomNums));

        }
        //create a method that takes one int Array
        //the method should return the largest # in that array
        public static int FindLargest(int[] arrayOfNums)
        {
            int largestNum = arrayOfNums[0];
            foreach (int num in arrayOfNums)
            {
                if (largestNum < num)
                {
                    largestNum = num;
                }
            }
            return largestNum;
        }

        //create a method that takes a string parameter then returns that string reversed
        public static string ReverseString(string stringOfWords)
        {
            string reversedWord = "";
            for (int i = stringOfWords.Length-1; i >0; i--)
            {
                reversedWord+=reversedWord[i] //concatenating onto our string in backwards order
            }
            return reversedWord;
        }
    }
}
