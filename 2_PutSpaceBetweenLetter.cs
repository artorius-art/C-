using System;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name : ");
            string nama = Console.ReadLine();
            System.Text.StringBuilder builder = new System.Text.StringBuilder(nama);
            for (int i = 0; i < (nama.Length*2); i+=2)
            {
                builder.Insert(i, " ");
            }
            Console.WriteLine("Put space between letter : " + builder);
        }
    }
}
