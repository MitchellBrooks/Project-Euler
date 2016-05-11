using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The prime factors of 13195 are 5, 7, 13 and 29.
//
//What is the largest prime factor of the number 600851475143 ?
//Difficulty (in my opinion) 2/5
//
//Not the most elegant solution but it is one that works

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            long factorMe = 600851475143;

            //while number is divisible by 2, write 2 and divide by 2
            while (factorMe % 2 == 0)
            {
                Console.WriteLine(2);
                factorMe = factorMe / 2;
            }
            
            //number is no longer divisible by 2; the number is now odd
            //we now divide number by all odd numbers (i=3; ... i = i+2)
            //if divisible, write the divisor and divide
            for (int i = 3; i <= Math.Sqrt(factorMe); i = i+2)
            {
                while (factorMe % i == 0)
                {
                    Console.WriteLine(i);
                    factorMe = factorMe/i;
                }
            }

            //if number is no longer divisible by a number less than its 
            //square root, the number is prime. print the number
            if (factorMe > 2)
                Console.WriteLine(factorMe);
            Console.Read();
        }
    }
}
