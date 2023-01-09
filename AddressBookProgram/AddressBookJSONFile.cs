using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBookJSONFile
    {
        public static string importpath = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\Import.csv";
        public static string exportpath = @"C:\Users\91973\source\repos\AddressBookProgram\AddressBookProgram\Export.json";
        public static void ImplementCSVtoJSON()
        {
            using (var reader = new StreamReader(importpath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>().ToList();
                Console.WriteLine("Read Data successfully from import.csv file and here data are");
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
                Console.WriteLine("Read data from csv file Write data to Json File");
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportpath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}