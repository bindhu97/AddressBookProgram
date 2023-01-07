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
        public static Dictionary<string, List<Contacts>> book = new Dictionary<string, List<Contacts>>();
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
        public static void Display()
        {
            foreach (var data in person)
            {
                Console.WriteLine();
                Console.WriteLine("1.FirstName: " + data.FName + "2.LastName: " + data.LName + "3.Address: " + data.Address + "4.City: " + data.City + "5.State: " + data.State + "6.Zipcode: " + data.Zipcode + "7.PhoneNumber: " + data.PhoneNumber);
            }
        }
        public static void editContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.FName == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string fName = Console.ReadLine();
                                data.FName = fName;
                                break;

                            case 2:
                                string lName = Console.ReadLine();
                                data.LName = lName;
                                break;

                            case 3:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;

                            case 4:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;

                            case 5:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;

                            case 6:
                                int zipcode = Convert.ToInt32(Console.ReadLine());
                                data.Zipcode = zipcode;
                                break;

                            case 7:
                                int phoneNumber = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = phoneNumber;
                                break;

                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesnot match");
                    }
                }
            }
        }
        public static void DeleteContact(string name)
        {
            Contacts contacts = new Contacts();
            foreach (var data in person)
            {
                if (data.FName == name)
                {
                    contacts = data;
                }
            }
            person.Remove(contacts);
        }
        public static void AddMultipleContacts()
        {
            Console.WriteLine("Enter the Number of Records you want to Insert");
            int number = (int)Convert.ToInt64(Console.ReadLine());
            while (number > 0)
            {
                CreateContacts();
                number--;
            }
        }
        public static void NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {

                number--;
                CreateContacts();
            }
            book.Add(Bookname, person.ToList());
        }
        public static void DisplayList()
        {
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (Contacts data in book[pair])
                {
                    Console.WriteLine("First Name: " + data.FName);
                    Console.WriteLine("Last Name: " + data.LName);
                    Console.WriteLine("Address: " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State: " + data.State);
                    Console.WriteLine("Zip : " + data.Zipcode);
                    Console.WriteLine("Phone Number: " + data.PhoneNumber);
                    Console.WriteLine("EmailID: " + data.Email);
                }
            }
        }
        public static void DuplicateContact()
        {
            Console.WriteLine("enter the name to check: ");
            string personName = Console.ReadLine();
            Console.WriteLine("Enter phonenumber");
            long phnnum = long.Parse(Console.ReadLine());
            bool check = person.Any(e => e.FName == personName && e.PhoneNumber == phnnum);
            if (check)
            {
                Console.WriteLine("contact is present");
            }
            else
            {
                Console.WriteLine("Contact is not present");
                NewUser();
            }
        }
        public static void SearchPersonByCity()
        {
            Console.WriteLine("enter the name to search: ");
            string personName = Console.ReadLine();
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (var data in person.FindAll(e => e.City == cityname && e.FName == personName))
                {
                    Console.WriteLine("The Contact Details of " + data.City + " are\n:" + data.FName + " " + data.LName + " " + data.Zipcode + " " + data.PhoneNumber);
                }
            }
        }
        public static void ViewPersonsByCity()
        {
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (var data in person.FindAll(e => e.City == cityname))
                {
                    Console.WriteLine("The Contact Details of " + data.City + " are\n:" + data.FName + " " + data.LName + " " + data.Zipcode + " " + data.PhoneNumber);
                }
            }
        }
        public static void CountPersonByCity()
        {
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            int count = 0;
            foreach (var pair in book.Keys)
            {
                foreach (var items in person.FindAll(e => e.City == cityname))
                {
                    count++;
                }
                Console.WriteLine("No of contacts {0} in city {1}", count, cityname);
            }
        }
        public static void SortPersonName()
        {
            foreach (var items in person.OrderBy(e => e.FName))
            {
                Console.WriteLine("First Name: " + items.FName);
                Console.WriteLine("Last Name: " + items.LName);
                Console.WriteLine("City : " + items.City);
                Console.WriteLine("Zip : " + items.Zipcode);
                Console.WriteLine("Phone Number: " + items.PhoneNumber);
            }
        }
        public static void SortbyCityName()
        {
            foreach (var items in person.OrderBy(e => e.City))
            {
                Console.WriteLine("First Name: " + items.FName);
                Console.WriteLine("Last Name: " + items.LName);
                Console.WriteLine("City : " + items.City);
                Console.WriteLine("Zip : " + items.Zipcode);
                Console.WriteLine("Phone Number: " + items.PhoneNumber);
            }
        }
        public static void SortbyZipcode()
        {
            foreach (var items in person.OrderBy(e => e.Zipcode))
            {
                Console.WriteLine("First Name: " + items.FName);
                Console.WriteLine("Last Name: " + items.LName);
                Console.WriteLine("City : " + items.City);
                Console.WriteLine("Zip : " + items.Zipcode);
                Console.WriteLine("Phone Number: " + items.PhoneNumber);
            }
        }
    }
}