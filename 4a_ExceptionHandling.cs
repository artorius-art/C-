using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, hasil ;
            Console.Write("Masukan A : ");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukan B : ");
            b = Convert.ToDecimal(Console.ReadLine());
            try
            {
                Console.WriteLine("Hasil : "+ (hasil = a / b));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Bilangan Tidak bisa di bagi Nol " );
            }
        }
    }
}
