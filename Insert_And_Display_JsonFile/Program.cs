using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_And_Display_JsonFile
{
    class Person
    {
        //Property Declear
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public long phonenumber { get; set; }
    }
    internal class File0
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string path = @"C:\Users\Saurabh\OneDrive\Desktop\Bridge NET\Class  work\Insert_and_Display_Data\Insert_And_Display_JsonFile\TextFile1.csv";
            Console.Write("How many Contact You Have To Add:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Person c = new Person();
                //Accepting Details From User
                Console.WriteLine("Enter Details For " + i + " Contact");
                Console.Write("Enter First Name:");
                c.firstname = Console.ReadLine();
                Console.Write("Enter Last Name:");
                c.lastname = Console.ReadLine();
                Console.Write("Enter Address:");
                c.address = Console.ReadLine();
                Console.Write("Enter City:");
                c.city = Console.ReadLine();
                Console.Write("Enter State:");
                c.state = Console.ReadLine();
                Console.Write("Enter ZipCode:");
                c.zipcode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Mobile Number:");
                c.phonenumber = Convert.ToInt64(Console.ReadLine());
                //Adding Details to list
                list.Add(c);
                Console.WriteLine("Contact Added");
                Console.WriteLine("\n");
            }
            //writing list data in file given using third party library
            JsonSerializer js = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                js.Serialize(jw, list);
            }
            Console.WriteLine("Data Inside File");
            //displaying data in file using third party library
            JsonSerializer js1 = new JsonSerializer();
            using (StreamReader sr = new StreamReader(path))
            using (JsonReader jr = new JsonTextReader(sr))
            {
                js1.Deserialize(jr);
            }
        }
    }
}