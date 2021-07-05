using System;
using PATA = ProjectA.TeamA;        //ProjectA.TeamA can be used as a namespace after the project is referenced in this project
using PATB = ProjectA.TeamB;        //ProjectA.TeamB can be used as a namespace after the project is referenced in this project

namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            //ProjectA.TeamA.ClassA.Print();  //To call method from another namespace and class, either use fully qualified name
            //ClassA.Print();                   // Or you can declare the namespace on the top and call the method using the class name
            PATA.ClassA.Print();

            //ProjectA.TeamB.ClassA.Print();
            PATB.ClassA.Print();
        }
    }
}


