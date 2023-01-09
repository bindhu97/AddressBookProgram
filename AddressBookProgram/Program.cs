using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class Program
    {
        //public static List<Contacts> Person = new List<Contacts>();
        public static void Main(string[] args)
        {
            Person person = new Person();
            while (true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("Select Option:\n" +
                    "1) Find the Create Contacts\n" +
                    "2) Find the Display of Contacts\n" +
                    "3) Find the edit contacts\n" +
                    "4) Find the delete contacts\n" +
                    "5) Ability to add Multiple person in AddressBook\n" +
                    "6) Ability to add Multiple AddressBook using Dictionary\n" +
                    "7) Find the DisplayList of Dictionary\n" +
                    "8) Ability to ensure there is no Duplicate entry of same person\n" +
                    "9) Ability to search Person in a City or State in Address Book\n" +
                    "10) Ability to view Person by City or State\n" +
                    "11) Ability to count Person in City or State\n" +
                    "12) Ability to Sort the Entries in Address Book\n" +
                    "13) Ability to Sort the Entry by City Name\n" +
                    "14) Ability to Sort the Entry by Zipcode\n" +
                    "15) Ability to Read FileIO in AddressBook\n" +
                    "16) Ability to ReadAllLines\n" +
                    "17) Ability to Read StreamReader\n" +
                    "18) Ability to Write in IO File\n" +
                    "19) Ability to Implement JSON TO CSV File\n");
                int option = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                switch (option)
                {
                    case 1:
                        Person.CreateContacts();
                        break;

                    case 2:
                        Person.Display();
                        break;

                    case 3:
                        Person.editContact();
                        break;

                    case 4:
                        Console.WriteLine("Enter name to delete the record");
                        string name = Console.ReadLine();
                        Person.DeleteContact(name);
                        break;

                    case 5:
                        Person.AddMultipleContacts();
                        break;

                    case 6:
                        Person.NewUser();
                        break;

                    case 7:
                        Person.DisplayList();
                        break;

                    case 8:
                        Person.DuplicateContact();
                        break;

                    case 9:
                        Person.SearchPersonByCity();
                        break;

                    case 10:
                        Person.ViewPersonsByCity();
                        break;

                    case 11:
                        Person.CountPersonByCity();
                        break;

                        case 12:
                            Person.SortPersonName();
                        break;

                    case 13:
                        Person.SortbyCityName();
                        break;

                    case 14:
                        Person.SortbyZipcode();
                        break;

                    case 15:
                        AddressBookFileIO.FileExists();
                        break;

                    case 16:
                        AddressBookFileIO.ReadAllLines();
                        break;

                    case 17:
                        AddressBookFileIO.FileStreamReader();
                        break;

                        case 18:
                        AddressBookFileIO.WriterPersonsContactsFile();
                        break;

                        case 19:
                        AddressBookCSVFile.ImplementJSONToCSV();
                        break;

                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}
