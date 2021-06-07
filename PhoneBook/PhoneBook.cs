using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhoneBook
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: { contact.Name}, { contact.Number}");
        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        //public void DeleteContact(Contact contact)
        //{
        //    _contacts.(contact);
        //}

        public void AddContact(Contact contact)
        {
        _contacts.Add(contact);
        }

    public void DisplayContact(string number)
    {
        var contact = _contacts.FirstOrDefault(c=> c.Number == number);
            if (contact == null)
            {
            Console.WriteLine("Contact not found!");
            }
            else 
            {
                DisplayContactDetails(contact);
            }
    }

        public void DisplayAllContacts()
        {
                DisplayContactDetails(_contacts);
        }

        public void EditContact(string searchEditContact)
        {
            var modifyContact = _contacts.Where(c => c.Name.Contains(searchEditContact)).ToList();
            DisplayContactDetails(modifyContact);
        }
        
        public void DisplayMatchingContacts(string searchContact)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchContact)).ToList();
            DisplayContactDetails(matchingContacts);
        }
    }
}
