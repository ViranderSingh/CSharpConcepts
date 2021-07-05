using System;
using System.Collections.Generic;

namespace Attributes
{
    class Program
    {
        static void Main()
        {
            //Calculator.Add(10, 20);

            int result = Calculator.Add(new List<int>() { 10, 20, 30 });
            Console.WriteLine(result);
        }
    }
}

public class Calculator
{
    //[Obsolete("Use Add(List<int> Numbers) Method", true)]   //This yields an error
    [Obsolete("Use Add(List<int> Numbers) Method")]       //This yields a warning
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach(int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }
}
