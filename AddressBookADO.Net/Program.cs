using System;

namespace AddressBookADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook ADO.Net");
            AddressBookDetails addressBook = new AddressBookDetails();
            addressBook.DisplayEmployee();
        }
    }
}
