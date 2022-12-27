using System.Net;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Addressbook
{
    public class Program
    {
        public static void Main(string[] args, Console console)
        {
            Console.WriteLine("Welcome to Addressbook program");
            Addressbook Book = new Addressbook();
            Console.WriteLine("Enter Number of Contacts To Add");
            int Contact = Convert.ToInt32(Console.ReadLine());
            while (Contact > 0)
            {
                Console.WriteLine("Enter FirstName");
                String FirstName = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                String LastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                String Address = Console.ReadLine();
                Console.WriteLine("Enter city");
                String city = Console.ReadLine();
                Console.WriteLine("Enter state");
                String state = Console.ReadLine();
                Console.WriteLine("Enter zipcode");
                int zipcode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Email id");
                string Email = Console.ReadLine();
                Console.WriteLine("enter phone number");
                long PhoneNumber = Convert.ToInt64(Console.ReadLine());

                Book.CreateContact(FirstName, LastName, Address, city, state, zipcode, PhoneNumber, Email);
                Contact--;
            }
        }
        public void DisplayContact(Addressbook[] ContactArray, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name: {0} {1}",ContactArray[i]. FirstName, ContactArray[i]. LastName);
                Console.WriteLine("Address: {0}", ContactArray[i].Address);
                Console.WriteLine("city: {0}", ContactArray[i].City);
                Console.WriteLine("state: {0}", ContactArray[i].State);
                Console.WriteLine("zipcode: {0}", ContactArray[i]. ZipCode);
                Console.WriteLine("phone number: {0}", ContactArray[i].PhoneNumber);
                Console.WriteLine("Email: {0}", ContactArray[i].Email);

                Console.WriteLine("*************");

            }

        }
    }
}

            
         
            