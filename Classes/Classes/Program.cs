using System;

class Customer
{
    string _firstName;
    string _lastName;

    //When a constructor is called without any paramters, it initiates the fields with a text shown below
    //this keyword over here represents the constructor with paramters
    public Customer() : this("No FirstName is provided", "No LastName is provided")
    {      
    }

    //Constructors are used to initialize the class fields
    //A constructor doesn't have a return type. It has access modifier, parameters and the same name as class.
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;        //this keyword represents the instance/ object of this class.
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name is {0} {1}", this._firstName, this._lastName);
    }

    //A Destructor has the same name as the class prefixed with a ~ symbol without any parameters and return type
    //it is used to clean up any vlaue of the class which it has been holding in its life time
    //it is automatically called when the garbage collector comes to collect the garbage values
    ~Customer()
    {
        //Clean up Code
    }

}

namespace Classes
{
    class Program
    {
        static void Main()
        {
            //Customer C1 = new Customer("Virander", "Singh");       //Constructors are called automatically when you create an instance of a class
            Customer C1 = new Customer();           //You can also call a constructor without any parameters
                                                    //and if no constructor is created, C# creates a default parameterless constructor for you 
            C1.PrintFullName();

            Customer C2 = new Customer("Virander", "Singh");
            C2.PrintFullName();
        }
    }
}
