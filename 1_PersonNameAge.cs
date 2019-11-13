using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{

    class Person
    {

        private string[] name;
        public string[] Name
        {
            get { return name; }
            set { name = value; }
        }

        private int[] age;
        public int[] Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return "Hi... I'm " + Name + " And i'm " + Age;
        }
    }


    class PersonDemo
    {
        public static void Main()
        {
            Person p = new Person();
            p.Age = new int[1000];
            p.Name = new string[1000];
            int[] ageTemp = new int[1000];
            Console.Write("Input Person Value : ");
            int persons = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= persons; i++)
            {

                Console.Write("Person " + i + " Name : ");
                p.Name[i] = Console.ReadLine();
                Console.Write("Birth Year of Person " + i + " : ");
                int currentTime = DateTime.Now.Year;
                ageTemp[i] = p.Age[i];
                if (!Int32.TryParse(Console.ReadLine(), out ageTemp[i]) || ageTemp[i] > currentTime || ageTemp[i] < 0)
                {
                    Console.WriteLine("Year invalid. Please enter a valid year:");
                }
                p.Age[i] = currentTime - ageTemp[i];

            }
            for (int i = 1; i <= persons; i++)
            {
                Console.WriteLine("Hi... I'm " + p.Name[i] + " And i'm " + p.Age[i] + " years old");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }

}
