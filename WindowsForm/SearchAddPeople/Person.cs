using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    class Person
    {
        // matches columns in Person table
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get
            {
                // concatinates fields 
                return $"{FirstName} {LastName} ({EmailAddress})";
            }
        }
    }
}
