using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC10_CountByCityState
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
        //Create Details
        public void AddPerson()                                                            
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
        //Search Result will show count by city and by state
        public void CountByCityState()                  
        {
            Console.WriteLine("Please enter the name of City or State");
            string CityOrState = Console.ReadLine();
            int Count = 0;
            foreach (var data in details)
            {
                string ActualCity = data.city;
                string ActualState = data.state;
                if (details.Exists(data1 => (ActualCity == CityOrState) || (ActualState == CityOrState)))
                {
                    Count++;
                }
            }
            Console.WriteLine($"There are {Count} Persons in {WantedCityOrState}");
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
                Console.WriteLine("Enter the option : \n1)AddPerson \n2)Display \n3)AddMultipleContacts \n4)CountByCityState");

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
                        Data.AddMultipleContacts();
                        break;
                    case 4:
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