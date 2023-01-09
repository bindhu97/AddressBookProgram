using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBookFileIO
    {
        public static void FileExists()
        {
            String path = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\AddressBook.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadAllLines()
        {
            String path = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\AddressBook.txt";
            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
            Console.WriteLine(lines[4]);
            Console.WriteLine(lines[5]);
            Console.WriteLine(lines[6]);

            Console.ReadKey();
        }
        public static void FileStreamReader()
        {
            string path = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\Import.csv";
            foreach (var data in Person.person)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("FirstName:" + data.FName);
                    sw.WriteLine("LastName: " + data.LName);
                    sw.WriteLine("City: " + data.City);
                    sw.WriteLine("Zipcode: " + data.Zipcode);
                    sw.WriteLine("PhoneNmuber: " + data.PhoneNumber);
                    sw.Close();
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = " ";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
        public static void WriterPersonsContactsFile()
        {
            string path = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\Import.csv";
            using (StreamWriter sr = File.AppendText(path))
            {
                string word = " New Address Book:= FirstName :- Bindhu\n LastName :- Shree\n Address :- Dodbele Road\n City :- Kengeri\n State :- Karnataka\n Zipcode :-   203130\n Phonenumber :- 9876543210\n Email Id :-  Bin!97@gmail.com\n";
                Console.WriteLine(word);
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
                Console.ReadKey();
        }
    }
}
