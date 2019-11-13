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
            List<string> katabBaru = new List<string>();
            Console.WriteLine("Enter some sentences : ");
            string kalimat = Console.ReadLine();
            string[] kata = kalimat.Split(" ");
            Console.WriteLine("Splited words and put into List<> : ");
            for(int i=0; i< kata.Length; i++)
            {
                katabBaru.Add(kata[i]);
            }
            katabBaru.ForEach(Console.WriteLine);
        }
    }
}
