using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int inputCount = Convert.ToInt32(Console.ReadLine());

        for (long j = 0; j < inputCount; j++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            int valid = 0;

            for (long i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    valid++;
                }
            }
            if (n == 1)
            {
                Console.WriteLine("Not prime");
            }
            else if (valid > 0)
            {
                Console.WriteLine("Not prime");
            }
            else Console.WriteLine("Prime");


        }



    }
}
