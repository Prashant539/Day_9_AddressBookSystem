using System;
namespace AddressBook
{
    internal class Program
    {
        public static List<Contacts> Person = new List<Contacts>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook.Person.CreateContacts();
            AddressBook.Person.editContact();
        }
    }
}
