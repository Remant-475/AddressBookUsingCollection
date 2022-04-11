using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbooknew
{
    internal class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public long zipCode;
        public long phoneNumber;
        public string email;

        public Contacts(string firstName, string lastName, string address, string city, string state, long zipCode, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void Display()
        {
            Console.WriteLine("First Name:{0}", firstName);
            Console.WriteLine("Last Name:{0}", lastName);
            Console.WriteLine("Address:{0}", address);
            Console.WriteLine("City: {0}", city);
            Console.WriteLine("State:{0}", state);
            Console.WriteLine("Zipcode:{0}", zipCode);
            Console.WriteLine("phone number:{0}", phoneNumber);
            Console.WriteLine("Email:{0}", email + "\n");
        }
    }
}
