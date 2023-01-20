using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class Contacts
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string Email { get; set; }
        public string DateAdded { get; set; }
    }
}