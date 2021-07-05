using System;
using System.Runtime.InteropServices;

namespace OptionalParameters
{
    class Program
    {
        static void Main()
        {
            //Using parameter array.
            //AddNumbers(10,20);        //The third parameter in the AddNumbers() is optional.
            //AddNumbers(10, 20, 30, 40, 50);
            //AddNumbers(10, 20, new object[] { 30, 40, 50 });    //The earlier representation is same as this one

            //Using method overloading.
            //AddNumbers(10, 20);   //Method with two parameters
            //AddNumbers(10, 20, new int[] { 30, 40, 50 });   //Method with 3 paramters

            //Specifying paramter default
            //AddNumbers(10, 20);
            //AddNumbers(10, 20, new int[] { 30, 40, 50 });

            //Named Parameters
            //Test(1);      //a is required parameter, whereas b and c are optional parameters
            //Test(10, c: 50);        //You can use the name of the parameter to assign the value

            //Using OptionalAttribute
            //AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });

        }

        //One way to make parameters optional is by using parameter arrays (params)
        //public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        //{
        //    int result = firstNumber + secondNumber;

        //    if(restOfNumbers != null)
        //    {
        //        foreach(int i in restOfNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine("Sum = " + result);
        //}

        //Second way is by using method overloading
        //public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
        //{
        //    int result = firstNumber + secondNumber;

        //    if (restOfNumbers != null)
        //    {
        //        foreach (int i in restOfNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine("Sum = " + result);
        //}

        ////Method overloading part
        //public static void AddNumbers(int firstNumber, int secondNumber)
        //{
        //    AddNumbers(firstNumber, secondNumber, null);
        //}

        //Third way is by specifying parameter defaults
        //Optional parameter must appear after all required parameters
        //public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        //{
        //    int result = firstNumber + secondNumber;

        //    if (restOfNumbers != null)
        //    {
        //        foreach (int i in restOfNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine("Sum = " + result);
        //}

        //Named Paramters (a is required parameter, whereas b and c are optional parameters)
        //public static void Test(int a, int b = 10, int c = 20)
        //{
        //    Console.WriteLine("a = " + a);
        //    Console.WriteLine("b = " + b);
        //    Console.WriteLine("c = " + c);
        //}

        //Fourth way is by using OptionalAttribute present in System.Runtime.InteropServices namespace
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = " + result);
        }
    }
}
