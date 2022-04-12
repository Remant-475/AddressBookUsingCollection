using System;
using System.Collections;

namespace AddressBookCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("Welcome to Address Book System");
                Console.WriteLine("\n"+"Choose 1: Family contacts");
                Console.WriteLine("Choose 2: Friend contacts");
                Console.WriteLine("Choose 3: Colleague contacts");
                Console.WriteLine("Choose 4: Others");
                Console.WriteLine("Choose 0: Exit");
                Console.WriteLine("\n"+"Enter the option ");

                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        var Family = new FamilyContacts();
                        int option = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 0: To Exit");

                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Family.AddContact();

                                    continue;
                                case 2:
                                    Family.ComputeDetails();
                                    continue;
                                case 3:
                                    Console.WriteLine("Enter first name");
                                    string key = Console.ReadLine();
                                    Family.EditContacts(key);
                                    break;
                                case 4:
                                    Family.DeleteContacts();
                                    break;
                                case 0:
                                    Console.WriteLine("Exit");
                                    break;
                                default:
                                    Console.WriteLine("Choose valid Option");
                                    break;
                            }


                        } while (option != 0);
                        break;
                    case 2:
                        var friend = new FriendContacts();
                        int options = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 0: To Exit");

                            options = int.Parse(Console.ReadLine());
                            switch (options)
                            {
                                case 1:
                                    friend.AddContact();
                                    continue;
                                case 2:
                                    friend.ComputeDetails();
                                    continue;
                                case 3:
                                    Console.WriteLine("Enter first name");
                                    string key = Console.ReadLine();
                                    friend.EditContacts(key);
                                    break;
                                case 4:
                                    friend.DeleteContacts();
                                    break;
                                case 0:
                                    Console.WriteLine("Exit");
                                    break;
                                default:
                                    Console.WriteLine("Choose valid Option");
                                    break;
                            }


                        } while (options != 0);
                        break;
                }
            } while (input != 0);
        }
    }
}