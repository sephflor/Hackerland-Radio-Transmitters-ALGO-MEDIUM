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

class Result
{

    /*
     * Complete the 'hackerlandRadioTransmitters' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY x
     *  2. INTEGER k
     */

    public static int hackerlandRadioTransmitters(List<int> x, int k)
    {
        x.Sort();
        int n = x.Count;
        int count = 0;
        int i = 0;

        while (i < n)
        {
            count++;
            int loc = x[i] + k;

            
            while (i < n && x[i] <= loc)
                i++;

            
            loc = x[i - 1] + k;

            
            while (i < n && x[i] <= loc)
                i++;
        }

        return count;
    }


    }


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> x = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(xTemp => Convert.ToInt32(xTemp)).ToList();

        int result = Result.hackerlandRadioTransmitters(x, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
