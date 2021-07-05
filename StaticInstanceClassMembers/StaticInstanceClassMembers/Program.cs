using System;

class Circle
{
    //float _PI = 3.141F;       //This is an instance member

    //static float _PI = 3.141F;  //Since PI is used in every circle object that is created, we use static keyword
    static float _PI;
    int _Radius;

    //Static constructors dont have access-modifiers and can be used to initialize a static field
    //Static costructor is called just once and it is called before the instance constructor
    static Circle()
    {
        Console.WriteLine("Static constructor called");
        Circle._PI = 3.141F;
    }

    public Circle(int Radius)
    {
        Console.WriteLine("Instance constructor called");
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        //return this._PI * this._Radius * this._Radius;    //You use this keyword to call an instance member

        return Circle._PI * this._Radius * this._Radius;    //Whereas you use class name to call a static member
    }
}

namespace StaticInstanceClassMembers
{
    class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area of the Circle is {0}", Area1);

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area of the Circle is {0}", Area2);
        }
    }
}
