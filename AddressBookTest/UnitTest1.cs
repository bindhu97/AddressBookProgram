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
    }
}