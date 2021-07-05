using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void Print()
        {
            base.ID = 101;

            AssemblyTwoClassI A2 = new AssemblyTwoClassI();
            A2.ID = 102;
        }
    }
}
