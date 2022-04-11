﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbooknew
{
    internal class AddressBookCollection
    {

        private List<Contacts> contactList;
        private List<Contacts> cityList;
        private List<Contacts> stateList;

        public AddressBookCollection()
        {
            contactList = new List<Contacts>();
        }

        public void AddContactDetails(string firstName, string lastName, string address, string city, string state, long zipCode, long phoneNumber, string email, Dictionary<string, List<Contacts>> stateDictionary, Dictionary<string, List<Contacts>> cityDictionary)
        {

            Contacts contact = contactList.Find(x => x.firstName.Equals(firstName));

            if (contact == null)
            {
                Contacts contactDetails = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
                this.contactList.Add(contactDetails);
                if (!cityDictionary.ContainsKey(city))
                {

                    cityList = new List<Contacts>();
                    cityList.Add(contactDetails);
                    cityDictionary.Add(city, cityList);
                }
                else
                {
                    List<Contacts> cities = cityDictionary[city];
                    cities.Add(contactDetails);
                }
                if (!stateDictionary.ContainsKey(state))
                {

                    stateList = new List<Contacts>();
                    stateList.Add(contactDetails);
                    stateDictionary.Add(state, stateList);
                }
                else
                {
                    List<Contacts> states = stateDictionary[state];
                    states.Add(contactDetails);
                }
            }

            else
            {
                Console.WriteLine("Person, {0} is already exist in the address book", firstName);
            }
        }
        public void DisplayContact()
        {

            if (contactList.Count != 0)
            {
                foreach (Contacts data in contactList)
                {
                    data.Display();
                }
            }
            else
                Console.WriteLine("No Contacts in AddressBook \n");
        }

        public void EditContact(string name)
        {

            foreach (Contacts data in contactList)
            {
                if (data.firstName.Equals(name))
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
                            data.lastName = Console.ReadLine();
                            Console.WriteLine("Data updated successfully \n");
                            break;
                        case 2:
                            data.address = Console.ReadLine();
                            Console.WriteLine("Data updated successfully \n");
                            break;
                        case 3:
                            data.city = Console.ReadLine();
                            Console.WriteLine("Data updated successfully \n");
                            break;
                        case 4:
                            data.state = Console.ReadLine();
                            Console.WriteLine("Data updated successfully \n");
                            break;
                        case 5:
                            data.zipCode = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Data updated successfully \n");
                            break;
                        case 6:
                            data.phoneNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Data updated successfully \n");
                            break;
                        case 7:
                            data.email = Console.ReadLine();
                            Console.WriteLine("Data updated successfully \n");
                            break;
                        default:
                            Console.WriteLine("Enter Valid Choice! \n");
                            break;
                    }
                }
                else
                    Console.WriteLine("No Contact With this Name! \n");
            }
        }

        public void DeleteContact(string deleteName)
        {
            foreach (Contacts item in contactList)
            {
                if (item.firstName.Equals(deleteName))
                {
                    this.contactList.Remove(item);
                    Console.WriteLine("Contact Deleted! \n");
                    break;
                }
            }
        }

        public static void DisplayPerson(Dictionary<string, AddressBookCollection> addressDictionary)
        {
            List<Contacts> list = null;
            Console.WriteLine("Enter City or State name");
            string name = Console.ReadLine();
            foreach (var data in addressDictionary)
            {
                AddressBookCollection address = data.Value;
                list = address.contactList.FindAll(x => x.city.Equals(name) || x.state.Equals(name));
                if (list.Count > 0)
                {
                    DisplayList(list);
                }
            }
            if (list == null)
            {
                Console.WriteLine("No person present in the address book with same city or state name");
            }
        }

        public static void DisplayList(List<Contacts> list)
        {
            foreach (var data in list)
            {
                data.Display();
            }
        }
        public static void CountPerson(Dictionary<string, List<Contacts>> dictionary)
        {
            foreach (var person in dictionary)
            {
                Console.WriteLine("Number of person {0}:", person.Value.Count);
            }
        }
    }
}

