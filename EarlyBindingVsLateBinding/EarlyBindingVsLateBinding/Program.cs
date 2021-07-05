using System;
using System.Reflection;

namespace EarlyBindingVsLateBinding
{
    class Program
    {
        static void Main()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("EarlyBindingVsLateBinding.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod =  customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Virander";
            parameters[1] = "Singh";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullName);

            //Early Binding Example
            //Customer C1 = new Customer();
            //string FullName = C1.GetFullName("Virander", "Singh");
            //Console.WriteLine("Full Name = {0}", FullName);
        }
    }

    //In late binding, this class needs to be avialable during runtime
    public class Customer
    {
        public string GetFullName(string Firstname, string LastName)
        {
            return Firstname + " " + LastName;
        }
    }
}

