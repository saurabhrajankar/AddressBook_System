using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_and_Display_Data
{
    class File0
    {
        public void Display(string path)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        static void Main(string[] args)
        {
            File0 f = new File0();
            string path = @"C:\Users\Saurabh\OneDrive\Desktop\Bridge NET\Class  work\Insert_and_Display_Data\Insert_and_Display_Data\TextFile1.txt";
            //Adding Contact
            Console.WriteLine("How many Contact You Have To Add:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter Details For {i} Contact");
                Console.Write("Enter First Name:");
                string firstname = Console.ReadLine();
                Console.Write("Enter Last Name:");
                string lastname = Console.ReadLine();
                Console.Write("Enter Address:");
                string address = Console.ReadLine();
                Console.Write("Enter City:");
                string city = Console.ReadLine();
                Console.Write("Enter State:");
                string state = Console.ReadLine();
                Console.Write("Enter ZipCode:");
                int zipcode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Mobile Number:");
                long phonenumber = Convert.ToInt64(Console.ReadLine());

                //Adding Details
                Console.WriteLine("Contact Add to Main.txt File");
                Console.WriteLine("\n");
                //adding details of user to file given
                using (StreamWriter F = File.AppendText(path))
                {
                    F.WriteLine("*************Contact Details****************");
                    F.WriteLine($"Name of person         : {firstname} {lastname}");
                    F.WriteLine($"Address of person is   : {address}");
                    F.WriteLine($"State                  : {state}");
                    F.WriteLine($"Zip                    : {zipcode}");
                    F.WriteLine($"City                   : {city}");
                    F.WriteLine($"Phone Number of person : {phonenumber}");
                    F.WriteLine("\n");
                    F.Close();
                }
            }
            Console.WriteLine("Data Inside File");
            //displaying data
            f.Display(path);
        }
    }
}
