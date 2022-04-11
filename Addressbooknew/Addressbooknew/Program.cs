namespace Addressbooknew
{ 

internal class Program
{          
  public static void Main(string[] args)
     {

         Console.WriteLine("Welcome to Address Book  \n");
        GetAddressBook getAddressBook = new GetAddressBook();
        getAddressBook.ReadUserInput();
         Console.ReadLine();
            }


        }
    }