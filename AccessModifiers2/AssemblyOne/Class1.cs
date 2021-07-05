using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        //internal int ID = 101;        //Internal can only be accessed from within this assembly and not from other assembly
        protected internal int ID = 101;      //Protected internal can be accessed from within this assembly and also from any derived class from other assembly
    }

    public class AssemblyOneClassII
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID); 
        }
    }
}
