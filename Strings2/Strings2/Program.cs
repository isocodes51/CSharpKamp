using System;

namespace Strings2
{
    class Solution
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tekrar Sayısını Gir:");
            int t = Convert.ToInt32(Console.ReadLine());
            // Solution abc = new Solution();
          for(int k = 1; k <= t; k++)
            {
                Hesapla("KamilSÖnmez");
            }
           

        }

        public static void Hesapla(string s)
        {
           // string isim = Console.ReadLine();
            string[] arr = { s };
            foreach (string ss in arr)
            {
                for (int i = 0; i < ss.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(ss[i]);
                    }
                }
                Console.Write(" ");
                for (int j = 0; j < ss.Length; j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write(ss[j]);
                    }
                }
            }
            Console.WriteLine(" ");
        }
    }
}
