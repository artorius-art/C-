using System;
public class FibonacciExample
{
    public static void Main(string[] args)
    {
        int nol = 0, satu = 1, n, batas;
        Console.Write("Jumlah Fibonacci : ");
        batas = int.Parse(Console.ReadLine());
        Console.Write(satu + " ");
        for (int i = 2; i <= batas; ++i)
        {
            n = nol + satu;
            Console.Write(n + " ");
            nol = satu;
            satu = n;
        }
    }
}
