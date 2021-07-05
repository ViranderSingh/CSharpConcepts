using System;

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

namespace ExplicitInterfaceImplementation
{
    class Program : I1, I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 interface Method");
        }

        //Explicitly implementing interface
        //void I1.InterfaceMethod()
        //{
        //    Console.WriteLine("I1 interface Method");
        //}

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface Method");
        }
        static void Main()
        {
            //Program P = new Program();
            //P.InterfaceMethod();    //Not sure which interface method is being invoked

            //1st way is that You can type cast the object with respective to interface and then invoke the corresponding method
            //((I1)P).InterfaceMethod();
            //((I2)P).InterfaceMethod();

            //2nd way is by pointing interface reference variable to a derived class object
            //I1 i1 = new Program();
            //i1.InterfaceMethod();

            //I2 i2 = new Program();
            //i2.InterfaceMethod();

            //3rd way is by making one interface method default and the other interface method explicit
            Program P = new Program();
            P.InterfaceMethod();

            ((I2)P).InterfaceMethod();

        }
    }
}
