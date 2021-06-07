using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my PhoneBook application!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add Contact:");
            Console.WriteLine("2. Modify Contact:");
            Console.WriteLine("3. Delete Contact:");
            Console.WriteLine("4. Search for Contact by Name:");
            Console.WriteLine("5. Search for Contact by Number:");
            Console.WriteLine("6. View all Contacts:");
            Console.WriteLine("Press 'x' to Exit:");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please enter Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Please enter Contact Number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Please enter Contact Name to Modify:");
                        var searchEditContact = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchEditContact);
                        break;

                    case "3":
                        Console.WriteLine("Please enter Contact Name to Delete:");
                        var deleteContact = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(deleteContact);
                        break;

                    case "4":
                        Console.WriteLine("Please enter Contact Name to Search:");
                        var searchContact = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchContact);
                        break;

                    case "5":
                        Console.WriteLine("Please enter Contact Number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;

                    case "6":
                        phoneBook.DisplayAllContacts();
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Please choose a valid option:");
                        break;
                }

                Console.WriteLine("Please choose an option:");
                userInput = Console.ReadLine();
            }
        }
    }
}
