using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace PhoneBook
{
    class PhoneBook
    {
        public const string dirPath = @"D:\Documents\Claim Academy\TestTextFiles\";
        public const string fileName = "PhoneBook.txt";
        public const string fullPath = dirPath + fileName;
        public List<Contact> _contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public List<Contact> Contacts
        {
            get { return Contacts; }
            set { this.Contacts = value; }
        }

        public void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contacts: { contact.strLastName + ", " + contact.strFirstName + ": " + contact.strNumber}");
        }

        public void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }


        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.strNumber == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

       public void DisplayAllContactsFromTextFile()
        {
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("There are contacts. Please add new contact.");
            }
            else
            {
                string [] lines = File.ReadAllLines(fullPath);
                foreach (string ln in lines)
                {
                    Console.WriteLine(ln);
                }
            }
        }

        public void DisplayMatchingContacts(string searchContact)
        {
            var matchingContacts = _contacts.Where(c => c.strLastName.Contains(searchContact)).ToList();
            DisplayContactsDetails(matchingContacts);
        }

        public void AddNewContact(string newContact)
        {
            try
            {
                if (!File.Exists(fullPath))
                {
                    File.WriteAllLines(fullPath, newContact.Split('\n'));
                    Console.WriteLine(newContact);
                }
                else
                {
                    string strNewContact = newContact;
                    File.AppendAllText(fullPath, strNewContact + "\n");
                    Console.WriteLine(strNewContact);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("This is the try/catch Exception: " + e.Message);
            }
        }
    }
}
