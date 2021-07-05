using System;

public class Student
{

    //Encapsulation: use set and get accessors to assign and return member values
    //We are using properties which use get and set accessors instead of getter and setter methods.
    private int _id;
    private string _name;
    private int _passMark = 35;

    //Auto-implemented properties introduced in C# 3.0
    public string Email { get; set; }       //Compiler automatically creates a private, anonymous Email field 

    public string City { get; set; }        //Compiler automatically creates a private, anonymous City field

    public int PassMark     //PassMark is a property
    {
        get
        {
            return this._passMark;
        }
        
    }

    public string Name      //Name is a property
    {
        set
        {
            if (string.IsNullOrEmpty(value))        //Value keyword is used to fetch the value to a property
            {
                throw new Exception("Name cannot be null of empty");
            }
            this._name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
        }
        
    }

    public int Id       //Id is a property
    {
        set
        {
            if (value <= 0)     //Value keyword is used to fetch the value to a property
            {
                throw new Exception("Student Id should be greater than zero");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
}

namespace PropertiesInCSharp
{
    class Program
    {
        static void Main()
        {
            Student C1 = new Student();
            C1.Id = 101;                    //value is assigned to a property just like initializing a field
            C1.Name = "Virander Singh";
            C1.City = "Kirkland";
            C1.Email = "virander.singh.sardar@gmail.com";

            Console.WriteLine("Student Id = {0}", C1.Id);

            Console.WriteLine("Student name = {0}", C1.Name);

            Console.WriteLine("Student Pass Mark = {0}", C1.PassMark);

            Console.WriteLine("Student City = {0}", C1.City);

            Console.WriteLine("Student Email = {0}", C1.Email);
        }
    }
}
