using System;
using System.Collections.Generic;

namespace DiagonalDiffrerence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();

            sayilar.Add(12);
            sayilar.Add(42);
            sayilar.Add(32);
            sayilar.Add(89);

            int toplam = 0;
            for (int i = 0; i < sayilar.Count; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine(toplam);
        }
    }
}
