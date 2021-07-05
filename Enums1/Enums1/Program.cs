using System;

namespace Enums1
{
    class Program
    {
        static void Main()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Virander Singh",
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                Name = "Gulbir Singh",
                Gender = Gender.Male
            };

            customers[2] = new Customer
            {
                Name = "Satinder Kaur",
                Gender = Gender.Female
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }

        public static string GetGender(Gender gender)
        {
            //The program is More readable and maintainable with the use of enum
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";

            }
        }
    }
}

public enum Gender
{
    Unknown,
    Male,
    Female
}

// 0 - Unknown
// 1 - Male
// 2 - Female
public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }

}