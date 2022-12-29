using AddressBookDay23;
using System.Net;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime;

namespace Addressbook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address book Program");
            AddressBook book = new AddressBook();
            int choice, choice2;
            string BookName = "MyBook";
            Console.WriteLine("What you like to do?\n1.Work on Default AddressBook\n2.Create new AddressBook");
            Console.WriteLine("Enter your Choice");
            choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    book.AddAddressBook(BookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Name of new address Book");
                    BookName = Console.ReadLine();
                    book.AddAddressBook(BookName);
                    break;
            }
            do
            {
                Console.WriteLine("Working On {0} AddressBook", BookName);
                Console.WriteLine("choice an option \n 1.AddContact\n2.Edit Contact\n3.DeleteContact\n4.ViewContact\n5.View All COntact\n6.Add New AddressBook\n7.Swich addressBook\n8.Exit Application");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter FirstName");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        string Address = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        string City = Console.ReadLine();
                        Console.WriteLine("Enter State");
                        string State = Console.ReadLine();
                        Console.WriteLine("Enter Zipcode");
                        int zipcode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        Console.WriteLine("Enter PhoneNumber");
                        long Phonenumber = Convert.ToInt64(Console.ReadLine());
                        book.CreateContact(FirstName, LastName, Address, City, State, zipcode, Phonenumber, Email, BookName);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To edit");
                        string Nametoedit = Console.ReadLine();
                        book.EditContact(Nametoedit, BookName);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To delete");
                        string Nametodelete = Console.ReadLine();
                        book.DeleteContact(Nametodelete, BookName);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name Of Contact To view");
                        string Nametoview = Console.ReadLine();
                        book.ViewContact(Nametoview, BookName);
                        break;
                    case 5:

                        book.ViewContact(BookName);
                        break;
                    case 6:
                        Console.WriteLine("Enter First Name for New Address book");
                        string newaddressbook = Console.ReadLine();
                        book.AddAddressBook(newaddressbook);
                        Console.WriteLine("Would you like to switch To " + newaddressbook);
                        Console.WriteLine("1.yes\n2.No");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            BookName = newaddressbook;
                        }
                        break;
                }
            } while (choice != 8);


        }

    }
}