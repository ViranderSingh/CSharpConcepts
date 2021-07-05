using System;

public class Student
{
    //Having class members as public is bad programming.
    //public int ID;
    //public string Name;
    //public int PassMark = 35;

    //Encapsulation: use getter and setter methods to assign and return member values
    private int _id;
    private string _name;
    private int _passMark = 35;

    public int GetPassMark()
    {
        return this._passMark;
    }

    public void SetName (string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be null of empty");
        }
        this._name = Name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "No name" : this._name;

        //if (string.IsNullOrEmpty(this._name))
        //{
        //    return "No name";
        //}
        //else
        //{
        //    return this._name;
        //}
    }
    public void SetId (int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id should be greater than zero");
        }
        this._id = Id;
    }

    public int GetId ()
    {
        return _id;
    }
}

namespace Properties
{
    class Program
    {
        static void Main()
        {
            //Student S1 = new Student();
            //S1.ID = -123;
            //S1.Name = null;
            //S1.PassMark = 0;

            //Console.WriteLine("ID = {0}, Name = {1}, PassMark = {2}", S1.ID, S1.Name, S1.PassMark);

            Student C1 = new Student();
            C1.SetId(101);
            //C1.SetName(null);

            Console.WriteLine("Student Id = {0}", C1.GetId());

            Console.WriteLine("Student name = {0}", C1.GetName());

            Console.WriteLine("Student Pass Mark = {0}", C1.GetPassMark());
        }
    }
}
