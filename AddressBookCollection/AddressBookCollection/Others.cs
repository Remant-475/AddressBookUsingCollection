using System;
using CsvHelper;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollection
{
    internal class Others
    {
        private List<AddressBook> ContactList;
        private Dictionary<string, AddressBook> ContactDetails;
        public Others()
        {
            ContactList = new List<AddressBook>();
            ContactDetails = new Dictionary<string, AddressBook>();
        }
        public void AddContact()
        {

            Console.WriteLine("Enter Your First name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Your State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Your Zipcode");
            string ZipCode = Console.ReadLine();
            Console.WriteLine("Enter Your Phone number");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Email Id");
            string Email = Console.ReadLine();
            AddressBook contact = new AddressBook(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            ContactList.Add(contact);
            ContactDetails.Add(FirstName, contact);

        }
        public void ComputeDetails()
        {
            foreach (KeyValuePair<string, AddressBook> item in ContactDetails)
            {
                Console.WriteLine(item.Value);
            }
        }
        public void EditContacts(string firstname)
        {
            {
                foreach (AddressBook data in ContactList)
                {
                    if (data.FirstName.Equals(firstname))
                    {
                        Console.WriteLine("Enter your choice:");
                        Console.WriteLine("1. Last Name");
                        Console.WriteLine("2. Address");
                        Console.WriteLine("3. City");
                        Console.WriteLine("4. State");
                        Console.WriteLine("5. Zip");
                        Console.WriteLine("6. Phone Number");
                        Console.WriteLine("7. Email");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Last Name");
                                data.LastName = Console.ReadLine();
                                Console.WriteLine("Data updated successfully \n");
                                break;
                            case 2:
                                Console.WriteLine("Enter Address");
                                data.Address = Console.ReadLine();
                                Console.WriteLine("Data updated successfully \n");
                                break;
                            case 3:
                                Console.WriteLine("Enter City");
                                data.City = Console.ReadLine();
                                Console.WriteLine("Data updated successfully \n");
                                break;
                            case 4:
                                Console.WriteLine("Enter State");
                                data.State = Console.ReadLine();
                                Console.WriteLine("Data updated successfully \n");
                                break;
                            case 5:
                                Console.WriteLine("Enter ZipCode");
                                data.ZipCode = Console.ReadLine();
                                Console.WriteLine("Data updated successfully \n");
                                break;
                            case 6:
                                Console.WriteLine("Enter PhoneNumber");
                                data.PhoneNumber = Console.ReadLine();
                                Console.WriteLine("Data updated successfully \n");
                                break;
                            case 7:
                                Console.WriteLine("Enter Email");
                                data.Email = Console.ReadLine();
                                Console.WriteLine("Data updated successfully \n");
                                break;
                            default:
                                Console.WriteLine("Enter Valid Choice! \n");
                                break;
                        }
                    }
                    else Console.WriteLine("No Contact With this Name! \n");
                }
            }
        }
        public void DeleteContacts()
        {
            Console.WriteLine("Enter The FirstName to Delete Contact ");
            string input = Console.ReadLine();
            if (ContactDetails.ContainsKey(input))
            {
                ContactDetails.Remove(input);
            }
            else
            {
                Console.WriteLine("FirstName not found");
            }
        }
        public void SearchPerson(string City)
        {
            var list = ContactList.FindAll(x => x.City.Equals(City));
            Console.WriteLine("Details of people who stays in city: ");
            foreach (var contact in list)
            {
                Console.WriteLine(contact);
            }
        }
        public void Count()
        {
            Console.WriteLine("Count Person By City And State wise");
            Console.WriteLine("Enter City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter state");
            string State = Console.ReadLine();
            var list = ContactList.FindAll(x => x.City.Equals(City) && x.State.Equals(State));
            foreach (var contact in list)
            {

                Console.WriteLine(contact);

            }
            var count = list.Count;
            Console.WriteLine("Total Persons in :"+City+"&"+State+"="+count);
        }
        public void SortByName()
        {
            var sortList = ContactDetails.OrderBy(x => x.Value.FirstName).ToList();
            foreach (var data in sortList)
            {
                Console.WriteLine(data.Value);
            }
        }
        public void SortByCityOrStateOrZipCode()
        {
            Console.WriteLine("Choose The option for Sorting ");
            Console.WriteLine("1: Sort by City");
            Console.WriteLine("2: Sort by State");
            Console.WriteLine("3: Sort by ZipCode");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var SortByCity = ContactDetails.OrderBy(x => x.Value.City).ToList();
                    foreach (var data in SortByCity)
                    {
                        Console.WriteLine(data.Value);
                    }
                    break;
                case 2:
                    var SortByState = ContactDetails.OrderBy(x => x.Value.State).ToList();
                    foreach (var data in SortByState)
                    {
                        Console.WriteLine(data.Value);
                    }
                    break;
                case 3:
                    var SortByZipCode = ContactDetails.OrderBy(x => x.Value.ZipCode).ToList();
                    foreach (var data in SortByZipCode)
                    {
                        Console.WriteLine(data.Value);
                    }
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
        public void WriteAddressBookToFile()
        {
            string Write = @"C:\Users\ASUS\Desktop\Addressbookcollection\AddressBookUsingCollection\TextFile\OthersAddressBook.txt";
            using (StreamWriter streamWriter = File.AppendText(Write))
            {
                foreach (var contactdetails in ContactDetails)
                {
                    streamWriter.WriteLine(contactdetails.ToString());
                }
                streamWriter.Close();
            }
        }
        public void ReadAddressBookFile()
        {
            string Filepath = @"C:\Users\ASUS\Desktop\Addressbookcollection\AddressBookUsingCollection\TextFile\OthersAddressBook.txt";
            string file = File.ReadAllText(Filepath);
            Console.WriteLine(file);
        }
        public void WriteAndReadFile()
        {
            Console.WriteLine("Choose The option to Write and Read File in AddressBook");
            Console.WriteLine("1: To Add Contact In File");
            Console.WriteLine("2: To Read a File");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    WriteAddressBookToFile();
                    break;
                case 2:
                    ReadAddressBookFile();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
        public void WriteAndReadAddressBookCSVFile()
        {
            string FilePath = @"C:\Users\ASUS\Desktop\Addressbookcollection\AddressBookUsingCollection\CSVFiles\OthersAddressBook.csv";
            using (var writer = new StreamWriter(FilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteHeader<AddressBook>();
                foreach (var contact in ContactList)
                {
                    csvWriter.NextRecord();
                    csvWriter.WriteRecord(contact);
                }
            }
            using (TextReader reader = new StreamReader(FilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressBook>().ToList();
                foreach (AddressBook contact in records)
                {
                    Console.WriteLine(contact);
                }
            }
        }
    }
}