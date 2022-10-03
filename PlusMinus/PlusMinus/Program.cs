using System;
using System.Collections.Generic;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr.Add(-4);
            arr.Add(3);
            arr.Add(-9);
            arr.Add(0);
            arr.Add(4);
            arr.Add(1);
            double toplamPoz,toplamNeg,toplamNotr;
            int sayacPoz = 0, sayacNeg=0,sayacNotr=0;
            for(int i=0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                    sayacPoz++;
                else if (arr[i] < 0)
                    sayacNeg++;
                else
                    sayacNotr++;
                   
                
                
            }
            toplamPoz = (double)sayacPoz / arr.Count;
            toplamNeg = (double)sayacNeg / arr.Count;
            toplamNotr = (double)sayacNotr / arr.Count;
            //toplam = (double)3 / 6;
            Console.WriteLine(toplamPoz.ToString("0.#0000"));
            Console.WriteLine(toplamNeg.ToString("0.#0000"));
            Console.WriteLine(toplamNotr.ToString("0.#0000"));


        }
    }
}
