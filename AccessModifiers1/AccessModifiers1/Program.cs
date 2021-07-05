using System;

namespace AccessModifiers1
{
    class Program
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            C1.ID = 123;

            CorporateCustomers C2 = new CorporateCustomers();
            C2.Name();
        }
    }
}

public class Customer
{
    private int _id;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    protected string FirstName;
}

public class CorporateCustomers : Customer
{
    public void Name()
    {
        //You can call a base class protected member by:
        //1. Using a derived class object
        //CorporateCustomers CC = new CorporateCustomers();
        //CC.FirstName = "Virander Singh";

        //2. By using base keyword
        //base.FirstName = "Virander Singh";

        //3. By using this keyword
        this.FirstName = "Virander Singh";

        //Console.WriteLine("First Name {0}", CC.FirstName);
        //Console.WriteLine("First Name {0}", base.FirstName);
        Console.WriteLine("First Name {0}", this.FirstName);
    }
}