﻿namespace AddressBookProgram
{
    class Program
    {
        public static List<Contacts> Person = new List<Contacts>();
        public static void Main(string[] args)
        {
            AddressBookProgram.Person.CreateContacts();
        }
    }
}