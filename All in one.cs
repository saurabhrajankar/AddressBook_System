using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Address_Book
{
    internal class Addressbook
    {
        class Contact //use my property method get set
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
        Dictionary<string, List<Contact>> Dictionary = new Dictionary<string, List<Contact>>();
        public void AddPerson()   //Create Details
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
        public void Display()     //Display the details
        {
            foreach (var data in People)
            {
                Console.WriteLine("*************Contact Details****************");
                Console.WriteLine($"Name of person           : {data.firstName} {data.lastName}");
                Console.WriteLine($"Address of person is     : {data.address}");
                Console.WriteLine($"State                    : {data.state}");
                Console.WriteLine($"Zip                      : {data.zipCode}");
                Console.WriteLine($"Email of person          : {data.email}");
                Console.WriteLine($"Phone Number of person   : {data.phoneNumber}");
                Console.WriteLine();
            }
        }
        public void Edit()  //Edit the details
        {
            Console.WriteLine("Enter the name of contact do you want to edit : ");
            string name = Console.ReadLine();
            foreach (var data in People)
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
        public void RemoveContact() //Remove the Contact
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
                Console.WriteLine();
            }
        }
        public void AddMultipleContacts() //Add multiple Contact
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
         public void AddUniqueContacts() //Add Unique Contact
         {
            Console.WriteLine("Welcome to Dictionary");
            Console.WriteLine("Enter the First name :");
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
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Contact list doesn't exist! Please create a contact list!");Console.WriteLine();
         }
        public void DisplayUniqueContacts() //Display the addressbook
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
                        Console.WriteLine($"Name of person          : {data.firstName} {data.lastName}");
                        Console.WriteLine($"Address of person is    : {data.address}");
                        Console.WriteLine($"State                   : {data.state}");
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
                Console.WriteLine("Enter the option : \n1)AddPerson \n2)Display \n3) Edit Contact \n4) Reamove Contact" +
                                                       " \n5)AddMultiplePerson \n6)UniqueBookName \n7)ViewBookName");
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
                        Data.Edit();
                        break;
                    case 4:
                        Console.WriteLine();
                        Data.RemoveContact();
                        break;
                    case 5:
                        Console.WriteLine();
                        Data.AddMultipleContacts();
                        break;
                    case 6:
                        Console.WriteLine();
                        Data.AddUniqueContacts();
                        break;
                        Console.WriteLine();
                    case 7:
                        Console.WriteLine();
                        Data.DisplayUniqueContacts();
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
        
    
