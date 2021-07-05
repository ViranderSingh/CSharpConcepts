using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethod
{
    public partial class SamplePartialClass
    {
        //partial void SamplePartialMethod();     //A partial method can be implemented in either same partial class or in different partial classes

        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SamplePartialMethod();      //This method isn't invoked until the declared partial method is implemented
        }
    }
}
