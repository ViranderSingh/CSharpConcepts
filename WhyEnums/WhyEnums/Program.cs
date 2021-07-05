using System;

namespace WhyEnums
{
    class Program
    {
        static void Main()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Virander Singh",
                Gender = 1
            };

            customers[1] = new Customer
            {
                Name = "Gulbir Singh",
                Gender = 1
            };

            customers[2] = new Customer
            {
                Name = "Satinder Kaur",
                Gender = 2
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }

        public static string GetGender(int gender)
        {
            //The program is less readable and maintainable because of the integral values
            switch(gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";

            }
        }
    }
}

// 0 - Unknown
// 1 - Male
// 2 - Female
public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; }

}
