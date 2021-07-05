using System;

//public delegate void SampleDelegate();

//public delegate int SampleDelegate();

public delegate void SampleDelegate(out int Integer);

namespace MulticastDelegate
{
    class Program
    {
        static void Main()
        {
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del();

            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);

            //del4 = del1 + del2 + del3 - del2;       //You can use + or - symbols when you are using different instances of a delegate
            //del4();     //del 4 is a multicast delegate as it has references to multiple functions

            //You use += or -= symbols when you are uisng just once instance of a delegate pointing to more than one functions
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del += SampleMethodTwo;
            //del += SampleMethodThree;
            //del -= SampleMethodTwo;
            //del();

            //Delegate with int return type
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del += SampleMethodTwo;
            //int DelegateReturnedValue = del();

            //Console.WriteLine("Value returned by Delegate = {0}", DelegateReturnedValue);

            //Delegate with output paramater
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            int DelegateReturnedOutputParameterValue = -1;

            del(out DelegateReturnedOutputParameterValue);

            Console.WriteLine("DelegateReturnedOutputParameterValue = {0}", DelegateReturnedOutputParameterValue);
        }

        //public static void SampleMethodOne()
        //{
        //    Console.WriteLine("Sample Method one invoked");
        //}

        //public static void SampleMethodTwo()
        //{
        //    Console.WriteLine("Sample Method two invoked");
        //}

        //public static void SampleMethodThree()
        //{
        //    Console.WriteLine("Sample Method three invoked");
        //}

        //public static int SampleMethodOne()
        //{
        //    return 1;
        //}

        //public static int SampleMethodTwo()
        //{
        //    return 2;
        //}

        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }

        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
    }
}
