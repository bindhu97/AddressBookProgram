using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookProgram
{
    public class Person
    {
        public static List<Contacts> person = new List<Contacts>();
        public static void CreateContacts()
        {
            Contacts contacts = new Contacts();

            Console.WriteLine("Enter First Name: ");
            contacts.FName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contacts.LName = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode: ");
            contacts.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter E-mail: ");
            contacts.Email = Console.ReadLine();

            person.Add(contacts);
        }
    }
}
