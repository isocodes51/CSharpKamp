using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir isim girin");
            String isim = Console.ReadLine();
           
            String[] arr = {isim};
            Console.WriteLine("Girdiğiniz isim:" +isim);
            foreach (string s in arr)
            {
                for(int i = 0; i < s.Length; i++)
                {
                 
                        if (i % 2 == 0) //Çift sayılı index
                        {
                            Console.Write(s[i]);

                        }
                }
                Console.Write(" ");
                for (int j = 0; j < s.Length; j++)
                {

                    if (j % 2 == 1) //Tek sayılı index
                    {
                        Console.Write(s[j]);

                    }
                }
            }
        }
    }
}
