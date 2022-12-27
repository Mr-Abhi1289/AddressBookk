using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class Addressbook
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public long PhoneNumber;
        public string Email;
        public Addressbook[] ContactArray;
        public int contact = 0;

        public Addressbook()
        {
            this.ContactArray = new Addressbook[5];
        }
        public Addressbook(string firstname, string lastname, string address, string state, string city, int zipcode, long phonenumber, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;
            PhoneNumber = phonenumber;
            Email = email;
        }

        public void CreateContact(string firstname, string lastname, string address, string city, string state, int zipcode, long phonenumber, string email)
        {
            ContactArray[this.contact] = new Addressbook(firstname, lastname, address, city, state, zipcode, phonenumber, email);
            contact++;
            Program program = new Program();
            program.DisplayContact(ContactArray, contact);
        }

        public void EditContact()
        {
            int i = 0;
            Console.WriteLine("enter the first name of the user  to modify");
            string FirstName = Console.ReadLine();
            while (ContactArray[i].FirstName != FirstName)
            {
                i++;
            }
            Console.WriteLine("enter the fields to modified\n1.FirstName\n2.LastName\n3.Address\n4.city\n5.state\n6.zipcode\n7.PhoneNumber\n8.email");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Modifyed Value");
                    string firstname = Console.ReadLine();
                    ContactArray[i].FirstName = firstname;
                    break;

                case 2:
                    Console.WriteLine("Enter the Modifyed Value");
                    string lastname = Console.ReadLine();
                    ContactArray[i].LastName = lastname;
                    break;

                case 3:
                    Console.WriteLine("Enter the Modifyed Value");
                    string address = Console.ReadLine();
                    ContactArray[i].Address = address;
                    break;

                case 4:
                    Console.WriteLine("Enter the Modifyed Value");
                    string city = Console.ReadLine();
                    ContactArray[i].City = city;
                    break;

                case 5:
                    Console.WriteLine("Enter the Modifyed Value");
                    string state = Console.ReadLine();
                    ContactArray[i].State = state;
                    break;

                case 6:
                    Console.WriteLine("Enter the Modifyed Value");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].ZipCode = zipcode;
                    break;

                case 7:
                    Console.WriteLine("Enter the Modifyed Value");
                    long phonenumber = Convert.ToInt64(Console.ReadLine());
                    ContactArray[i].PhoneNumber = phonenumber;
                    break;

                case 8:
                    Console.WriteLine("Enter the Modifyed Value");
                    string email = Console.ReadLine();
                    ContactArray[i].Email = email;
                    break;
            }
            Program book = new Program();
            book.DisplayContact(ContactArray,contact);
            
        }
    }
}







