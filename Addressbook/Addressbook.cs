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
    }
}







