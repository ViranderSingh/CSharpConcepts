using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public partial class PartialCustomerClass
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get => _lastName; set => _lastName = value; }
    }
}