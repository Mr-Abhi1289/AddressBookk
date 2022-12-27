using System;
using System.Collections.Generic;
using System.Linq;
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
        public Addressbook(string firstname,string lastname,string address,string state,string city,int zipcode,long phonenumber,string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            City = city;
            State =state;
            ZipCode = zipcode;
            PhoneNumber = phonenumber;
            Email = email;
        }
        
        public void displaycontact()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("city: {0}", City);
            Console.WriteLine("state: {0}", State);
            Console.WriteLine("zipcode: {0}",ZipCode);
            Console.WriteLine("phone number: {0}", PhoneNumber);
            Console.WriteLine("Email: {0}",Email);
          
        }
    }
}
