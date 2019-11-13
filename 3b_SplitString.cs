using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitString1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some sentences : ");
            string kalimat = Console.ReadLine();
            string[] kata = kalimat.Split(" ");
            Console.WriteLine("Splited words: ");
            foreach (string kalimatBaru in kata)
            {
                Console.WriteLine(kalimatBaru);
            }
        }
    }
}
