using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class day29Result
{

    /*
     * Complete the 'bitwiseAnd' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. INTEGER K
     */

    public static int bitwiseAnd(int N, int K)
    {
        List<int> s = [];

        for (int a = 1; a <= N; a++)
        {
            for (int b = a + 1; b <= N; b++)
            {
                if ((a & b) < K)
                {
                    s.Add(a & b);
                }
            }
        }

        return s.Max();
    }

}

class day29Solution
{
    public static void day29Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = day29Result.bitwiseAnd(count, lim);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
