using System;

namespace Enums2
{
    class Program
    {
        static void Main()
        {
            //Before changing the underlying type of the enum
            //int[] Values = (int[])Enum.GetValues(typeof(Gender));

            //foreach (int value in Values)
            //{
            //    Console.WriteLine(value);
            //}

            //After changing the underlying type of the enum
            //short[] Values = (short[])Enum.GetValues(typeof(Gender));

            //foreach (short value in Values)
            //{
            //    Console.WriteLine(value);
            //}

            //string[] Names = Enum.GetNames(typeof(Gender));

            //foreach(string name in Names)
            //{
            //    Console.WriteLine(name);
            //}

            //Type Casting integer to enum and vice versa
            //Gender gender = (Gender)3;
            //int Num = (int)Gender.Unknown;

            //Gender gender = Season.Spring;  //This is not possible even though both are enums
            //For the above assignment to work, use casting
            Gender gender = (Gender)Season.Spring;      //This is possible
        }
    }
}

public enum Gender
{
    Unknown = 1,
    Male = 2,
    Female = 3
}

//You can change the underlying type of the enum from int to any other type like short
//public enum Gender : short
//{
//    //Unknown,
//    //Male,
//    //Female

//    //Values assigned to enum members can be changed too
//    Unknown = 1,
//    Male = 5,
//    Female = 23
//}

public enum Season
{
    Winter = 1,
    Spring = 2,
    Summer = 3
}