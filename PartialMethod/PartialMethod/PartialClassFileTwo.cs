using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethod
{
    public partial class SamplePartialClass
    {
        //Partial Methods have two parts, Method Definition and Method Implementation
        //Partial Method Definition
        partial void SamplePartialMethod();     //A partial method can be implemented in either same partial class or in different partial classes

        //Partial Method Implementation
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

        //Partial Method signatures should be the same for both definition and implementation
    }
}
