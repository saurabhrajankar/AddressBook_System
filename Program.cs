using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Address_Book_
{
    public class Addressbook
    {
        //use property method get set
        class Contact
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
        public void AddPerson()                                                            //Create Details
        {
            Contact contact = new Contact();
            int Add = 0;
            Console.WriteLine("Enter the First name");
            contact.firstName = Console.ReadLine();
            string FirstNameAdded = contact.firstName;
            foreach (var data in details)
            {
                if (details.Exists(data1 => data.firstName == FirstNameAdded))            //Check Duplicate Contact
                {
                    Add++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record.");
                    break;
                }
            }
            if (Add == 0)
            {
                //Console.WriteLine("Enter the First Name");
                //contact.firstName = Console.ReadLine();
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
        public void Display()     //Display the details
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
        //Search Result will show count by city and by state
        public void CountByCityState()
        {
            Console.WriteLine("Please enter the name of City or State");
            string WantedCityOrState = Console.ReadLine();
            int Count = 0;
            foreach (var data in details)
            {
                string ActualCity = data.city;
                string ActualState = data.state;
                if (details.Exists(data1 => (ActualCity == WantedCityOrState) || (ActualState == WantedCityOrState)))
                {
                    Count++;
                }
            }
            Console.WriteLine($"There are {Count} Persons in {WantedCityOrState}");
        }
        //Edit the details
        public void Edit()
        {
            Console.WriteLine("Enter the name of contact do you want to edit : ");
            string name = Console.ReadLine();
            foreach (var data in details)
            {
                if (data.firstName == name)
                {
                    Console.WriteLine("choose the option to change the data : \n1) firstName\n2)lastName\n3)address\n4)City\n5)State\n" +
                                                                               "6)Zip\n7)Email\n8)Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the first name : ");
                            string frstName = Console.ReadLine();
                            data.firstName = frstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the last name : ");
                            string lstName = Console.ReadLine();
                            data.lastName = lstName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Address : ");
                            string addrss = Console.ReadLine();
                            data.address = addrss;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the city : ");
                            string City = Console.ReadLine();
                            data.city = City;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the State : ");
                            string State = Console.ReadLine();
                            data.state = State;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the zip Code : ");
                            int ZipCode = Convert.ToInt32(Console.ReadLine());
                            data.zipCode = ZipCode;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the email : ");
                            string Email = Console.ReadLine();
                            data.email = Email;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the Phone Number : ");
                            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            data.phoneNumber = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("please choose from above options :");
                            break;
                    }
                    Console.WriteLine();
                    Display();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Contact not found{name}");
                    Console.WriteLine();
                }
            }
        }
        //Remove the Contact
        public void RemoveContact()
        {
            Console.WriteLine("Enter the name do you want to remove : ");
            string name = Console.ReadLine();
            foreach (var data in details)
            {
                if (data.firstName == name)
                {
                    Console.WriteLine("given name contact exists");
                    details.Remove(data);
                    Console.WriteLine("contact deleted successfully");
                    break;
                }
                else
                {
                    Console.WriteLine($"given name does not contact exists{name}");
                }
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
        //Add Unique Contact
        public void AddUniqueContacts()
        {
            Console.WriteLine("Welcome to Dictionary");
            Console.WriteLine("Enter the First name :");
            string name = Console.ReadLine();
            foreach (var data in details)
            {
                if (details.Contains(data))
                {
                    if (data.firstName == name)
                    {
                        Console.WriteLine("Enter the Unique name : ");
                        string unique = Console.ReadLine();
                        if (Dictionary.ContainsKey(unique))
                        {
                            Console.WriteLine("Person name already exists! ");
                        }
                        Dictionary.Add(unique, details);
                        Console.WriteLine("added in dictionary!");
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Contact list doesn't exist! Please create a contact list!"); Console.WriteLine();
        }
        //Display the addressbook
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter the unique name (key value) : ");
            string name = Console.ReadLine();
            foreach (var contacts in Dictionary)
            {
                if (contacts.Key.Contains(name))
                {
                    foreach (var data in details)
                    {
                        if (details.Contains(data))
                            Console.WriteLine("*************Contact Details****************");
                        Console.WriteLine($"Name of person          : {data.firstName} {data.lastName}");
                        Console.WriteLine($"Address of person is    : {data.address}");
                        Console.WriteLine($"State                   : {data.state}");
                        Console.WriteLine($"City                    : {data.city}");
                        Console.WriteLine($"Zip                     : {data.zipCode}");
                        Console.WriteLine($"Email of person         : {data.email}");
                        Console.WriteLine($"Phone Number of person  : {data.phoneNumber}");
                        Console.WriteLine();
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
            Console.WriteLine("Welcome To Address Book Problem");
            Addressbook Data = new Addressbook();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)AddPerson \n2)Display \n3)SortingList city \n4)SortingList State \n5)" +
                                                        "Edit Contact \n6)Remove Contact \n7)AddMultiplePerson " +
                                                        "\n8)AddUniqueContacts\n9)DisplayUniqueContacts\n10)CountByCityState ");
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
                        Data.Edit();
                        break;
                    case 6:
                        Console.WriteLine();
                        Data.RemoveContact();
                        break;
                    case 7:
                        Console.WriteLine();
                        Data.AddMultipleContacts();
                        break;
                    case 8:
                        Console.WriteLine();
                        Data.AddUniqueContacts();
                        break;
                    case 9:
                        Console.WriteLine();
                        Data.DisplayUniqueContacts();
                        break;
                    case 10:
                        Console.WriteLine();
                        Data.CountByCityState();
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
