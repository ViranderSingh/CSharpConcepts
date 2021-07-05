using System;

namespace TypeTypeMembersAccessModifiers
{
    class Program
    {
        static void Main()
        {
            Customer C1 = new Customer();
            C1.Id = 123;
            C1.FirstName = "Virander Singh";
            C1.LastName = "Sardar";
            Console.WriteLine(C1.GetFullName());
        }
    }
}

public class Customer       //Class is a Type
{
    #region Fields  
    //Fields are Type Members
    private int _id;
    private string _firstName;
    private string _lastName;
    #endregion

    #region Properties
    //Properties are Type memebers
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    #endregion

    #region Methods
    //Methods are Type Members
    public string GetFullName()
    {
        return this._firstName + " " + this._lastName;
    }
    #endregion
}
