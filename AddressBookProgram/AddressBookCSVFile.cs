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
    public class AddressBookCSVFile
    {
        public static string importfilePath = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\Import.csv";
        public static string exportfilePath = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\Export.csv";
        public static void ImplementJSONToCSV()
        {
            using (var reader = new StreamReader(importfilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>().ToList();
                Console.WriteLine("Read Data from csvFile");
                foreach (var data in Person.person)
                {
                    Console.Write("\n" + data.FName);
                    Console.Write("\n" + data.LName);
                    Console.Write("\n" + data.Address);
                    Console.Write("\n" + data.City);
                    Console.Write("\n" + data.State);
                    Console.Write("\n" + data.Zipcode);
                    Console.Write("\n" + data.PhoneNumber);
                    Console.Write("\n" + data.Email);
                    Console.Write("\n");
                }

                using (var writer = new StreamWriter(exportfilePath))
                using (var csvImport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvImport.WriteRecords(records);
                }
            }
        }
    }
}
