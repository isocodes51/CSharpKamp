using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Gir:");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            if (n % 2 == 1) Console.WriteLine("Weird"); //n tek ise
            else
            {
                if (n > 2 || n < 5) Console.WriteLine("Not Weird"); //n çift ve n > 2 veya n < 5
                else if (n > 6 || n < 20) Console.WriteLine("Weird");
                else if (n > 20) Console.WriteLine("Not Weird");
                else Console.WriteLine("weird");
            }
            
        }
    }
}
