using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_EnsureTheNoDuplicateTheEntry
{
    internal class Addressbook
    {
        //use property method get set
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
        List<Contact> details = new List<Contact>();

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
                if (details.Exists(details => data.firstName == FirstNameToBeAdded))
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
                Console.WriteLine("Enter the Zip Code");
                contact.zipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Phone Number");
                contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the Email");
                contact.email = Console.ReadLine();
                details.Add(contact);
            }
            Console.WriteLine();
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
                Console.WriteLine($"Zip                      : {data.zipCode}");
                Console.WriteLine($"Email of person          : {data.email}");
                Console.WriteLine($"Phone Number of person   : {data.phoneNumber}");
                Console.WriteLine();
            }
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
                Console.WriteLine("Enter the option : \n1)AddPerson \n2)Display \n3)Edit Contact \n4)AddMultiplePerson Contact");
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