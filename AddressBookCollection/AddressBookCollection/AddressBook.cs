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


    }
}