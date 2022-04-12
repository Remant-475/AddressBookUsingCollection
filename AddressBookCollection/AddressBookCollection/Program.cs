using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBookCollection
{
    public class AddressBook
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string ZipCode;
        private string PhoneNumber;
        private string Email;

        public AddressBook(string FirstName, string LastName, string Address, string City,
            string State, string ZipCode, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }

        public override string ToString()
        {
            return " Details of " + FirstName + " " + LastName + " are: " + "Address : " + Address + " City : " + City + "\n"
                                       + "                                  " + "State : " + State + " ZipCode : " + ZipCode + "\n"
                                       + "                                  " + "PhoneNumber : " + PhoneNumber + " Email : " + Email;
        }

        internal class Program
        {
            private ArrayList contactList;
            private Dictionary<string, AddressBook> contactsDetails;

            public Program()
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



            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Address Book Program");
                var Details = new Program();
                int option = 0;
                do
                {
                    Console.WriteLine("Choose 1: To Add a Contact");
                    Console.WriteLine("Choose 2: To compute Contacts");
                    Console.WriteLine("Choose 0: To Exit");

                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Details.AddContact();
                            continue;
                        case 2:
                            Details.ComputeDetails();
                            continue;

                        case 0:
                            Console.WriteLine("Exit");
                            break;

                        default:
                            Console.WriteLine("Choose valid Option");
                            break;
                    }


                } while (option != 0);
            }
        }
    }
}