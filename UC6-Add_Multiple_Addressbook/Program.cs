using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_Add_Multiple_Addressbook
{
    class Create_Contact
    {
        class Contact
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string state { get; set; }
            public long phoneNumber { get; set; }
            public string email { get; set; }
            public int zipCode { get; set; }
        }
        List<Contact> People = new List<Contact>();
        Dictionary<string, List<Contact>> Dictionary= new Dictionary<string, List<Contact>>();
        public void AddPerson()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter the First Name");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter the Adresss");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter the State");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter the Zip Code");
            contact.zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone Number");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email");
            contact.email = Console.ReadLine();
            People.Add(contact);
        }
        public void AddMultipleContacts()
        {
            Console.WriteLine("Enter the number of contact to ADD");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                AddPerson();
                n--;
            }
        }
        public void AddUniqueContacts()
        {
            Console.WriteLine("Welcome to Dictionary");
            Console.WriteLine("Enter the First name : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (People.Contains(data))
                {
                    if (data.firstName == name)
                    {
                        Console.WriteLine("Enter the Unique name : ");
                        string unique = Console.ReadLine();
                        if (Dictionary.ContainsKey(unique))
                        {
                            Console.WriteLine("Person name already exists! ");
                        }
                        Dictionary.Add(unique, People);
                        Console.WriteLine("added in dictionary!");
                        //return;
                    }
                }
            }
            Console.WriteLine("Contact list doesn't exist! Please create a contact list!");
            //return;
        }
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter the unique name (key value) : ");
            string name = Console.ReadLine();
            foreach (var contacts in Dictionary)
            {
                if (contacts.Key.Contains(name))
                {
                    foreach (var data in People)
                    {
                        if (People.Contains(data))
                        Console.WriteLine("*************Contact Details****************");
                        Console.WriteLine($"Name of person           : {data.firstName} {data.lastName}");
                        Console.WriteLine($"Address of person is     : {data.address}");
                        Console.WriteLine($"State                    : {data.state}");
                        Console.WriteLine($"Zip                      : {data.zipCode}");
                        Console.WriteLine($"Email of person          : {data.email}");
                        Console.WriteLine($"Phone Number of person   : {data.phoneNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("This unique name doesnt exists!");
                }
            }
            Console.WriteLine("Oops! Unique Contact does not exist.Please create a unique contact.");
        }
        public static void Main(String[] args)
        {
            Create_Contact AddressBook = new Create_Contact();
            AddressBook.AddMultipleContacts();
            AddressBook.AddUniqueContacts();
            AddressBook.DisplayUniqueContacts();
            Console.ReadLine();
        }

    }
}
