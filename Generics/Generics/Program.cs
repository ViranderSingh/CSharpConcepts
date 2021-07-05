using System;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            //bool Equal = Calculator.AreEqual(1, 2);
            //bool Equal = Calculator.AreEqual("A", "B");
            //bool Equal = Calculator.AreEqual<string>("A", "B");     //When using Generics on method
            bool Equal = Calculator<string>.AreEqual("A", "B");     //When using Generics on class

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            
        }
    }

    //public class Calculator
    //{
    //    //public static bool AreEqual(int Value1, int Value2)
    //    //public static bool AreEqual(object Value1, object Value2)       //use object type to make it available for any data type
    //    //{
    //    //    return Value1 == Value2;
    //    //}

    //    //Making the method Generic
    //    public static bool AreEqual<T>(T Value1, T Value2)
    //    {
    //        return Value1.Equals(Value2);
    //    }
    //}

    //Making the class Generic
    public class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
