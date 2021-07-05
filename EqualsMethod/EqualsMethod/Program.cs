using System;

namespace EqualsMethod
{
    class Program
    {
        static void Main()
        {
            int i = 10;
            int j = 10;

            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));

            Customer C1 = new Customer();
            C1.FirstName = "Virander";
            C1.LastName = "Singh";

            Customer C2 = C1;

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));

            Customer C3 = new Customer();
            C3.FirstName = "Virander";
            C3.LastName = "Singh";

            Console.WriteLine(C1 == C3);            //Comparison Operator '==' gives us reference equality 
            Console.WriteLine(C1.Equals(C3));       //Whereas .Equals() gives us value quality. Currently this returns false and needs to be overrriden
            //.Equals() base method doesn't know what to check for and hence needs to be overriden
            //After overriding .Equals(), we get true as the values are true but the references are different so '==' still returns false
        }

        public enum Direction
        {
            East = 1,
            West = 2,
            North = 3,
            South = 4
        }

        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override bool Equals(object obj)
            {
                if(obj == null)
                {
                    return false;
                }

                if(!(obj is Customer))
                {
                    return false;
                }

                return this.FirstName == ((Customer)obj).FirstName &&
                    this.LastName == ((Customer)obj).LastName;  
            }

            //In C#, if you override .Equals(), then it is recommended to also override .GetHashCode()
            public override int GetHashCode()
            {
                return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
            }
        }
    }
}
