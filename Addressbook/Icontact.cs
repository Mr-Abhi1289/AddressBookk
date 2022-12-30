using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
     interface IContact
    {
        public void CreateContact(string firstname, string lastname, string address, string city, string state, int zipcode, long phonenumber, string email,string BookName);
        public void ViewContact(string name, string BookName);

        public void EditContact(string Name, string BookName);
        public void DeleteContact(string Name, string BookName);
        public void AddAddressBook(string BookName);
    
    }
        
}
