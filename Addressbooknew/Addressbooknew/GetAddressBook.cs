using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbooknew
{
    internal class GetAddressBook
    {
        static AddressBookCollection addressBookMain = new AddressBookCollection();
        static Dictionary<string, AddressBookCollection> addressBook = new Dictionary<string, AddressBookCollection>();

        public void ReadUserInput()
        {
            bool CONTINUE = true;


            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.Add contacts");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Edit Details");
                Console.WriteLine("5.Delete Person");
                Console.WriteLine("6.Add Multiple Address Book");
                Console.WriteLine("7.Delete Any Address Book");
                Console.WriteLine("8.Display person by city or state name");
                Console.WriteLine("0.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GetAddressBook.AddBook();
                        break;
                    case 2:
                        AddDetails(GetAddressBook.BookName(addressBook));
                        break;
                    case 3:
                        addressBookMain = GetAddressBook.BookName(addressBook);
                        addressBookMain.DisplayContact();
                        break;
                    case 4:
                        addressBookMain = GetAddressBook.BookName(addressBook);
                        Console.WriteLine("Enter the first name of person");
                        string name = Console.ReadLine();
                        addressBookMain.EditContact(name);
                        break;
                    case 5:
                        addressBookMain = GetAddressBook.BookName(addressBook);
                        Console.WriteLine("Enter the first name of person");
                        string deleteName = Console.ReadLine();
                        addressBookMain.DeleteContact(deleteName);
                        break;
                    case 6:
                        AddMultipleAddressBook();
                        break;
                    case 7:
                        Console.WriteLine("Enter address book name to delete:");
                        string addressBookName = Console.ReadLine();
                        addressBook.Remove(addressBookName);
                        break;
                    case 8:
                        AddressBookCollection.DisplayPerson(addressBook);
                        break;
                    case 0:
                        CONTINUE = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AddBook()
        {
            Console.WriteLine("Enter address book name:");
            string addBookName = Console.ReadLine();
            addressBook.Add(addBookName, addressBookMain);
        }

        public static void AddDetails(AddressBookCollection addressMain)
        {
            Console.WriteLine("Enter first Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            long zipCode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();

            addressMain.AddContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        }

        public void AddMultipleAddressBook()
        {
            Console.WriteLine("How many AddressBook,you want to Add");
            int Number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                GetAddressBook.AddBook();
            }
            Console.WriteLine("All Address Book Added successfully! \n");
        }

        public static AddressBookCollection BookName(Dictionary<string, AddressBookCollection> addBook)
        {
            addressBook = addBook;
            Console.WriteLine("Enter address book name:");
            string name = Console.ReadLine();
            AddressBookCollection address = addressBook[name];
            return address;
        }
    }
}
