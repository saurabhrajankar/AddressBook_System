using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC8_Search_Per_City_Or_State
{
    internal class Addressbook
    {
        class Contact //use property method get set
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public long phoneNumber { get; set; }
            public string email { get; set; }
            public int zipCode { get; set; }
        }
        List<Contact> details = new List<Contact>();
        Dictionary<string, List<Contact>> Dictionary = new Dictionary<string, List<Contact>>();
        
        //Create Details
        public void AddPerson()   
        {
            Contact contact = new Contact();
            int Add = 0;
            Console.WriteLine("Enter the First name :");
            contact.firstName = Console.ReadLine();
            string FirstNameToBeAdded = contact.firstName;
            foreach (var data in details)
            {
                if (details.Exists(data1 => data.firstName == FirstNameToBeAdded))
                {
                    Add++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record.");
                    break;
                }
            }
            if (Add == 0)
            {
                Console.WriteLine("Enter the Last Name");
                contact.lastName = Console.ReadLine();
                Console.WriteLine("Enter the Adresss");
                contact.address = Console.ReadLine();
                Console.WriteLine("Enter the State");
                contact.state = Console.ReadLine();
                Console.WriteLine("Enter the City");
                contact.city = Console.ReadLine();
                Console.WriteLine("Enter the Zip Code");
                contact.zipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Phone Number");
                contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the Email");
                contact.email = Console.ReadLine();
                details.Add(contact);
            }
        }
        // sorting the contact list by city name in alphabetical order
        public void SortingListcity()
        {
            List<Contact> SortedList = new List<Contact>();
            SortedList = details.OrderBy(s => s.city).ToList();
            foreach (var data in SortedList)
            {
                if (details.Contains(data))
                {
                    Console.WriteLine("*************Contact Details****************");
                    Console.WriteLine($"Name of person           : {data.firstName} {data.lastName}");
                    Console.WriteLine($"Address of person is     : {data.address}");
                    Console.WriteLine($"State                    : {data.state}");
                    Console.WriteLine($"City                     : {data.city}");
                    Console.WriteLine($"Zip                      : {data.zipCode}");
                    Console.WriteLine($"Email of person          : {data.email}");
                    Console.WriteLine($"Phone Number of person   : {data.phoneNumber}");
                    Console.WriteLine();
                }
            }
        }
        // sorting the contact list by state name in alphabetical order
        public void SortingListState()
        {
            List<Contact> SortedList = new List<Contact>();
            SortedList = details.OrderBy(s => s.state).ToList();
            foreach (var data in SortedList)
            {
                if (details.Contains(data))
                {
                    Console.WriteLine("*************Contact Details****************");
                    Console.WriteLine($"Name of person           : {data.firstName} {data.lastName}");
                    Console.WriteLine($"Address of person is     : {data.address}");
                    Console.WriteLine($"State                    : {data.state}");
                    Console.WriteLine($"City                     : {data.city}");
                    Console.WriteLine($"Zip                      : {data.zipCode}");
                    Console.WriteLine($"Email of person          : {data.email}");
                    Console.WriteLine($"Phone Number of person   : {data.phoneNumber}");
                    Console.WriteLine();
                }
            }
        }
        //Display the details
        public void Display()     
        {
            foreach (var data in details)
            {
                Console.WriteLine("*************Contact Details****************");
                Console.WriteLine($"Name of person           : {data.firstName} {data.lastName}");
                Console.WriteLine($"Address of person is     : {data.address}");
                Console.WriteLine($"State                    : {data.state}");
                Console.WriteLine($"City                     : {data.city}");
                Console.WriteLine($"Zip                      : {data.zipCode}");
                Console.WriteLine($"Email of person          : {data.email}");
                Console.WriteLine($"Phone Number of person   : {data.phoneNumber}");
                Console.WriteLine();
            }
        }
        //Add multiple Contact
        public void AddMultipleContacts()
        {
            Console.WriteLine("Enter the number of contact to ADD");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                AddPerson();
                n--;
            }
            Console.WriteLine();
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome To Address Book Problem");
            Addressbook Data = new Addressbook();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)AddPerson \n2)Display \n3)SortingListcity \n4)SortingListState \n5)Add Multiple Addressbook");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine();
                        Data.AddPerson();
                        break;
                    case 2:
                        Console.WriteLine();
                        Data.Display();
                        break;
                    case 3:
                        Console.WriteLine();
                        Data.SortingListcity();
                        break;
                    case 4:
                        Console.WriteLine();
                        Data.SortingListState();
                        break;
                    case 5:
                        Console.WriteLine();
                        Data.AddMultipleContacts();
                        break;
                    default:
                        {
                            Console.WriteLine("Please Select Below Option");
                        }
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}