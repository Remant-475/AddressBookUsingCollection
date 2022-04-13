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
                            Console.WriteLine("Choose 5: To Search Person by City Name");
                            Console.WriteLine("Choose 6: To Count Person City And State");
                            Console.WriteLine("Choose 7: To Sort Person By Name ");
                            Console.WriteLine("Choose 8: To Sort Person By City Or State Or ZipCode ");
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
                                    string firstname = Console.ReadLine();
                                    Family.EditContacts(firstname);
                                    break;
                                case 4:
                                    Family.DeleteContacts();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string city = Console.ReadLine();
                                    Family.SearchPerson(city);
                                    break;
                                case 6:
                                    Family.Count();
                                    break;
                                case 7:
                                    Family.SortByName();
                                    break;
                                case 8:
                                    Family.SortByCityOrStateOrZipCode();
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
                        var Friend = new FriendContacts();
                        int Option = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 5: To Search Person by City Name");
                            Console.WriteLine("CHoose 6: To Count Person City And State");
                            Console.WriteLine("Choose 7: To Sort Person By Name ");
                            Console.WriteLine("Choose 8: To Sort Person By City Or State Or ZipCode ");
                            Console.WriteLine("Choose 0: To Exit");

                            Option = int.Parse(Console.ReadLine());
                            switch (Option)
                            {
                                case 1:
                                    Friend.AddContact();

                                    continue;
                                case 2:
                                    Friend.ComputeDetails();
                                    continue;
                                case 3:
                                    Console.WriteLine("Enter first name");
                                    string firstname = Console.ReadLine();
                                    Friend.EditContacts(firstname);
                                    break;
                                case 4:
                                    Friend.DeleteContacts();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string city = Console.ReadLine();
                                    Friend.SearchPerson(city);
                                    break;
                                case 6:
                                    Friend.Count();
                                    break;
                                case 7:
                                    Friend.SortByName();
                                    break;
                                case 8:
                                    Friend.SortByCityOrStateOrZipCode();
                                    break;

                                case 0:
                                    Console.WriteLine("Exit");
                                    break;
                                default:
                                    Console.WriteLine("Choose valid Option");
                                    break;
                            }


                        } while (Option != 0);
                        break;
                    case 3:
                        var Colleague = new ColleagueContacts();
                        int oPtion = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 5: To Search Person by City Name");
                            Console.WriteLine("CHoose 6: To Count Person City And State");
                            Console.WriteLine("Choose 7: To Sort Person By Name ");
                            Console.WriteLine("Choose 8: To Sort Person By City Or State Or ZipCode ");
                            Console.WriteLine("Choose 0: To Exit");

                            option = int.Parse(Console.ReadLine());
                            switch (oPtion)
                            {
                                case 1:
                                    Colleague.AddContact();

                                    continue;
                                case 2:
                                    Colleague.ComputeDetails();
                                    continue;
                                case 3:
                                    Console.WriteLine("Enter first name");
                                    string firstname = Console.ReadLine();
                                    Colleague.EditContacts(firstname);
                                    break;
                                case 4:
                                    Colleague.DeleteContacts();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string city = Console.ReadLine();
                                    Colleague.SearchPerson(city);
                                    break;
                                case 6:
                                    Colleague.Count();
                                    break;
                                case 7:
                                    Colleague.SortByName();
                                    break;
                                case 8:
                                    Colleague.SortByCityOrStateOrZipCode();
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
                    case 4:
                        var Others = new Others();
                        int options = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 5: To Search Person by City Name");
                            Console.WriteLine("CHoose 6: To Count Person City And State");
                            Console.WriteLine("Choose 7: To Sort Person By Name ");
                            Console.WriteLine("Choose 8: To Sort Person By City Or State Or ZipCode ");
                            Console.WriteLine("Choose 0: To Exit");

                            options = int.Parse(Console.ReadLine());
                            switch (options)
                            {
                                case 1:
                                    Others.AddContact();
                                    continue;
                                case 2:
                                    Others.ComputeDetails();
                                    continue;
                                case 3:
                                    Console.WriteLine("Enter first name");
                                    string firstname = Console.ReadLine();
                                    Others.EditContacts(firstname);
                                    break;
                                case 4:
                                    Others.DeleteContacts();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string city = Console.ReadLine();
                                    Others.SearchPerson(city);
                                    break;
                                case 6:
                                    Others.Count();
                                    break;
                                case 7:
                                    Others.SortByName();
                                    break;
                                case 8:
                                    Others.SortByCityOrStateOrZipCode();
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
                    case 0: Console.WriteLine("Exit");
                        break;
                }
            } while (input != 0);

        }
    }
}