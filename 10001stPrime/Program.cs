using System;

//By listing the first six prime numbers: 2, 3, 5, 7, 11, 
//and 13, we can see that the 6th prime is 13.
//
//What is the 10,001st prime number?
//Difficulty (in my opinion) 1/5

namespace _10001st_Prime
{
    class Program
    {
        Boolean isPrime(long x)
        {
            Boolean prime = true;

            for (int i = 3; i <= Math.Sqrt(x); i = i + 2)
            {
                if (x % i == 0)
                {
                    prime = false;
                }
            }

            return prime;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            long[] primes = new long[10001];
            primes[0] = 2;  //hack job. couldn't figure out a good test for the prime 2
            int i = 1;
            long numberToCheck = 3;
            while (i < 10001)
            {
                if (p.isPrime(numberToCheck))
                {
                    primes[i] = numberToCheck;
                    i++;
                }
                numberToCheck += 2;
            }

            Console.WriteLine(primes[10000]);
            Console.Read();
        }
    }
}
