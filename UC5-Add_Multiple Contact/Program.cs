using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_Add_Multiple_Contact
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
        public void Display()      //Display the details
        {
            foreach (var data in People)
            {
                if (People.Contains(data))
                    Console.WriteLine("*************Contact Details****************");
                Console.WriteLine($"Name of person : {data.firstName} {data.lastName}");
                Console.WriteLine($"Address of person is : {data.address}");
                Console.WriteLine($"State : {data.state}");
                Console.WriteLine($"Zip : {data.zipCode}");
                Console.WriteLine($"Email of person : {data.email}");
                Console.WriteLine($"Phone Number of person : {data.phoneNumber}");
            }
        }
        public void RemoveContact()
        {
            Console.WriteLine("Enter the name do you want to remove : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.firstName == name)
                {
                    Console.WriteLine("given name contact exists");
                    People.Remove(data);
                    Console.WriteLine("contact deleted successfully");
                    break;
                }
                else
                {
                    Console.WriteLine($"given name does not contact exists{data.firstName}");
                }
            }
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
        public static void Main(String[] args)
        {
            Create_Contact AddressBook = new Create_Contact();
            AddressBook.AddPerson();
            AddressBook.Display();
            AddressBook.RemoveContact();
            AddressBook.AddMultipleContacts();
            Console.ReadLine();
        }

    }
}
