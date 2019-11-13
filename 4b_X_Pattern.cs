using System;

namespace Pattern
{

public class Program
    {
        public static void Main()
        {
            int number, i, j;
            Console.Write("Enter Row Value : ");
            number = int.Parse(Console.ReadLine());
            for (j = number; j > 0; j--)
            {
                for (i = 0; i < number; i++)
                {
                    if (i == (j-1) || (number-i) == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
