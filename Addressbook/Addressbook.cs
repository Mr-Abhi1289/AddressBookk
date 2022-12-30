using Addressbook;

namespace AddressBook
{
    public class AddressBook : IContact
    {

        public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();

        public void CreateContact(string firstname, string lastname, string address, string city, string state, int zipcode, long phonenumber, string email, string BookName)
        {
            Contact contact = new Contact();
            contact.FirstName = firstname;
            contact.LastName = lastname;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.ZipCode = zipcode;
            contact.Email = email;
            contact.PhoneNumber = phonenumber;
            addressBookDictionary[BookName].addressBook.Add(contact.FirstName, contact);
            Console.WriteLine("Added Succesfully");

        }
        public void ViewContact(string name, string BookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[BookName].addressBook)
            {
                if (item.Key.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("FirstName;" + item.Value.FirstName);
                    Console.WriteLine("LastName;" + item.Value.LastName);
                    Console.WriteLine("Address;" + item.Value.Address);
                    Console.WriteLine("City;" + item.Value.City);
                    Console.WriteLine("State;" + item.Value.State);
                    Console.WriteLine("Zip;" + item.Value.ZipCode);
                    Console.WriteLine("Email;" + item.Value.Email);
                    Console.WriteLine("PhoneNumber;" + item.Value.PhoneNumber);
                }
            }
        }
        public void ViewContact(string BookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[BookName].addressBook)
            {
                Console.WriteLine("FirstName;" + item.Value.FirstName);
                Console.WriteLine("LastName;" + item.Value.LastName);
                Console.WriteLine("Address;" + item.Value.Address);
                Console.WriteLine("City;" + item.Value.City);
                Console.WriteLine("State;" + item.Value.State);
                Console.WriteLine("Zipcode;" + item.Value.ZipCode);
                Console.WriteLine("Email;" + item.Value.Email);
                Console.WriteLine("PhoneNumber;" + item.Value.PhoneNumber);

            }

        }
        public void EditContact(string name, string bookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[bookName].addressBook)
            {
                if (item.Key.Equals(name))
                {


                    Console.WriteLine("Enter Field To Modify\n1.FirstNmae\n2.LastName\n3.Address\n4.City\n5.State\n6.Zip\n7.Email\n8.PhoneNumber");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Modifed Value");
                            string firstname = Console.ReadLine();
                            item.Value.FirstName = firstname;
                            break;
                        case 2:
                            Console.WriteLine("Enter the Modifed Value");
                            string lastname = Console.ReadLine();
                            item.Value.LastName = lastname;
                            break;
                        case 3:
                            Console.WriteLine("Enter the Modifed Value");
                            string Address = Console.ReadLine();
                            item.Value.Address = Address;
                            break;
                        case 4:
                            Console.WriteLine("Enter the Modifed Value");
                            string city = Console.ReadLine();
                            item.Value.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter the Modifed Value");
                            string state = Console.ReadLine();
                            item.Value.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter the Modifed Value");
                            int zipcode = Convert.ToInt32(Console.ReadLine());
                            item.Value.ZipCode = zipcode;
                            break;
                        case 7:
                            Console.WriteLine("Enter the Modifed Value");
                            string mailid = Console.ReadLine();
                            item.Value.Email = mailid;
                            break;
                        case 8:
                            Console.WriteLine("Enter the Modifed Value");
                            long phonenumber = Convert.ToInt64(Console.ReadLine());
                            item.Value.PhoneNumber = phonenumber;
                            break;


                    }
                    Console.WriteLine("Edited Successfully");
                }
            }
        }
        public void DeleteContact(string name, string BookName)
        {
            if (addressBookDictionary[BookName].addressBook.ContainsKey(name))
            {
                addressBookDictionary[BookName].addressBook.Remove(name);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Not found Try Again");
            }
        }
        public void AddAddressBook(string BookName)
        {
            AddressBook book = new AddressBook();
            addressBookDictionary.Add(BookName, book);
            Console.WriteLine("AddressBook Created");
        }
        public Dictionary<string, AddressBook> GetaddressBook()
        {
            return addressBookDictionary;
        }

       
    }
}