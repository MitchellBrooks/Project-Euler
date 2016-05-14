using System;

//How many 20 digit numbers n(without any leading zero) exist such 
//that no three consecutive digits of n have a sum greater than 9?
//Difficulty (in my opinion) 3/5

namespace Consecutive_digits
{
    public static class Program
    {

        public static long getCount(int d1, int d2, int remainDigits, long[,,] count)
        {
            if (remainDigits == 0)
                return 1;
            else {
                if (count[d1,d2,remainDigits] == 0)
                    for (int i = 0; i <= 9 - (d1 + d2); i++)
                        count[d1,d2,remainDigits] += getCount(d2, i, remainDigits - 1, count);
                return count[d1,d2,remainDigits];
            }
        }

        static void Main(string[] args)
        {
            long numberOfNumbers = 0;
            long[,,] number = new long[10,10,20];
            
            for (int i = 1; i <= 9; i++)
                numberOfNumbers += getCount(0, i, 19, number);

            Console.WriteLine(numberOfNumbers);
            Console.Read();
        }
    }
}
