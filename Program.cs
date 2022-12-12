namespace AddressBookProgram
{
    class Program
    {
        //public static List<Contacts> Person = new List<Contacts>();
        public static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("Select Option:\n" +
                    "1) Find the Create Contacts\n" +
                    "2) Find the Display of Contacts\n" +
                    "3) Find the edit contacts\n" +
                    "4) Find the delete contacts\n" + 
                    "5) Find the ability to add multiple Person\n" + 
                    "6) Add multiple address to system\n");
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
                        string number = Console.ReadLine();
                        Person.DeleteContact(number);
                        break;

                    case 5:
                        Person.AddContact();
                        break;

                    case 6:
                        int addCount = Convert.ToInt32(Console.ReadLine());

                        Dictionary<int, string> dictionary = new Dictionary<int, string>();

                        for (int i = 1; i <= addCount; i++)
                        {
                            count++;
                            List<Person> newAdd = new List<Person>();
                            dictionary.Add(i, "New Dictionary");
                        }
                        Console.WriteLine(count + " Address Book Created..");
                        Person.AddContact();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}