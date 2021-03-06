﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Each new term in the Fibonacci sequence is generated by adding 
//the previous two terms.By starting with 1 and 2, the first 10 
//terms will be:
//
//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//
//By considering the terms in the Fibonacci sequence whose values 
//do not exceed four million, find the sum of the even-valued terms.
//Difficulty (in my opinion) 1/5

namespace EvenFibNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int term = 1;
            int lastTerm = 0;
            int temp = 0;
            int sum = 0;

            while(term < 4000000)
            {
                if(term % 2 == 0)
                {
                    sum += term;
                }
                temp = term;
                term = term + lastTerm;
                lastTerm = temp;
            }

            Console.WriteLine("The sum of even fibbonaci number under 4,000,000 is: " + sum);
            Console.Read();
        }
    }
}
