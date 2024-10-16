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



class day28Solution
{
    public static void day28Main(string[] args)
    {
        List<string> names = new List<string>();
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];

            var regex = new Regex("[A-Za-z._]+@gmail.com");
            if (regex.IsMatch(emailID))
            {
                names.Add(firstName);
            }
        }
        names.Sort();
        names.ForEach(n => Console.WriteLine(n));


    }
}
