using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//
//Find the sum of all the primes below two million.
//Difficulty (in my opinion) 1/5
//Probably not the most eloquent solution but it does find the proper answer

namespace Sum_of_primes
{
    class Program
    {

        Boolean check(long number)
        {
            Boolean prime = true;
            for (int i = 3; i <= Math.Sqrt(number); i = i + 2)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            //I include 2 in the sum to start with. I could not figure out how to check for that prime properly
            long sum = 2;

            //Because the first prime (2) is already in the sum, start by checking 3
            //Increment the number to check by 2 because no even number will need to be checked
            for (long numberToCheck = 3; numberToCheck < 2000000; numberToCheck = numberToCheck + 2)
            {
                if (p.check(numberToCheck))
                {
                    sum = sum + numberToCheck;
                }
            }

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
