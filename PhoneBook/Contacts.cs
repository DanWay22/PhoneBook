using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class Contact
        { 
        public Contact(string firstName, string lastName, string number)
            {
            strFirstName = firstName;
            strLastName = lastName;
            strNumber = number;
            }

        public string strFirstName { get; set; }
        public string strLastName { get; set; }
        public string strNumber { get; set; }
    
    }
}
