using AddressBookProgram;

namespace AddressBookTest
{
    public class Tests
    {
        [Test]
        public void ShouldRetrieveAllPerson()
        {
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPerson();
            Assert.That(count, Is.EqualTo(5));
        }
        [Test]
        public void ShouldUpdatePerson()
        {
            Contacts model = new Contacts
            {
                ID = 3,
                Address = "6th cross street",
                PhoneNumber = "86565434476"
            };
            AddressBookRepository repository = new AddressBookRepository();
            int result = repository.UpdatePresoninAddressBook(model);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void GetpersonbyDate()
        {
            Contacts model = new Contacts();
            model.DateAdded = "17-01-2023";
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPersonDate(model);
            Assert.AreEqual(2, count);
        }
        [Test]
        public void GetpersonbyCityName()
        {
            Contacts model = new Contacts();
            model.City = "Bangalore";
            AddressBookRepository repository = new AddressBookRepository();
            int count = repository.GetPersonByCity(model);
            Assert.AreEqual(1, count);
        }
        [Test]
        public void AddpersonInDatabase()
        {
            Contacts model = new Contacts
            {
                FName = "Parnika",
                LName = "Rao",
                Address = "Dodbele Road",
                PhoneNumber = "988888888",
                Email = "Pari97@gmail.com",
                City = "Kengeri",
                State = "Karnataka",
                Zipcode = 123456,
                DateAdded = "27-05-2021"
            };
            AddressBookRepository repository = new AddressBookRepository();
            int result = repository.AddPresoninAddressBook(model);
            Assert.AreEqual(1, result);
        }
    }
}