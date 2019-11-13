using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prima
{
    class Program
    {
        public static bool cekPrima(int n)
        {
            bool cek = true;
            int factor = n / 2;
            for (int i = 2; i <= factor; i++)
            {
                if ((n % i) == 0)
                {
                    cek = false;
                }
            }
            return cek;
        }
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(5);
            num.Add(7);
            num.Add(11);
            num.Add(15);
            num.Add(17);
            for (int i = 0; i < num.Count; i++)
            {
                if (cekPrima(num[i]) == true)
                {
                    Console.WriteLine(num[i] + " is a Prime number ");
                }
                else
                {
                    Console.WriteLine(num[i] + " is not a Prime number ");
                }
            }
        }
    }
}
