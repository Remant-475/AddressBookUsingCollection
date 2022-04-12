using System;

namespace AddressBookCollection
{

    class AddresBook
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zipcode;
        public string PhoneNumber;
        public string EmailId;

        public void AdressBook(string FirstName, string LastName, string Address, string City, string State, string Zipcode, string PhoneNumber, string EmailId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            AddresBook book = new AddresBook();

            Console.WriteLine("Enter First name");
            book.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name");
            book.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            book.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            book.City = Console.ReadLine();
            Console.WriteLine("enter State");
            book.State = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode");
            book.Zipcode = Console.ReadLine();
            Console.WriteLine("Enter your Phone number");
            book.PhoneNumber = Console.ReadLine();
            Console.WriteLine("enter your email id");
            book.EmailId = Console.ReadLine();


        }
    }

}