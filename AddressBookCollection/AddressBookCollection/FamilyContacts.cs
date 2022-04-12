using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollection
{
    internal class FamilyContacts
    {

        private ArrayList contactList;
        private Dictionary<string, AddressBook> contactsDetails;

        public FamilyContacts()
        {
            contactList = new ArrayList();
            contactsDetails = new Dictionary<string, AddressBook>();
        }

        public void AddContact()
        {
            Console.WriteLine("Enter your First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your city: ");
            string City = Console.ReadLine();
            Console.WriteLine("Enter your State: ");
            string State = Console.ReadLine();
            Console.WriteLine("Enter your Zip: ");
            string ZipCode = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number: ");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Email: ");
            string Email = Console.ReadLine();
            AddressBook addresses = new AddressBook(FirstName.ToLower(), LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            contactList.Add(addresses);
            contactsDetails.Add(FirstName.ToLower(), addresses);

        }
        public void ComputeDetails()
        {
            foreach (KeyValuePair<string, AddressBook> contact in contactsDetails)
            {
                Console.WriteLine(contact.Value);
            }
        }

        public void EditContacts(string firstname)
        {
            if (contactsDetails.ContainsKey(firstname))
            {
                Console.WriteLine("Enter your First Name: ");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name: ");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter your Address: ");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter your city: ");
                string City = Console.ReadLine();
                Console.WriteLine("Enter your State: ");
                string State = Console.ReadLine();
                Console.WriteLine("Enter your Zip: ");
                string ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your Phone Number: ");
                string PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter your Email: ");
                string Email = Console.ReadLine();
                AddressBook addresses = new AddressBook(FirstName.ToLower(), LastName, Address, City, State, ZipCode, PhoneNumber, Email);
                contactList.Add(addresses);
                contactsDetails.Add(FirstName.ToLower(), addresses);
            }
            else
            {
                Console.WriteLine("First Name doesnt exist");
            }
        }
        public void DeleteContacts()
        {
            Console.WriteLine("Enter first name to Delete");
            string input = Console.ReadLine();
            if (contactsDetails.ContainsKey(input.ToLower()))
            {
                contactsDetails.Remove(input.ToLower());
            }
            else
            {
                Console.WriteLine("first name doesnt exist");
            }
        }
    }
}