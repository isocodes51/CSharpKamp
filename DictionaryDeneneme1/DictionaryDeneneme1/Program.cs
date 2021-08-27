using System;
using System.Collections.Generic;

namespace DictionaryDeneneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(135,"Kamil Sönmez");
            Ogrenci.Add(136,"Ada Burhane");

            Console.WriteLine("Öğrenci No Giriniz");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
                Console.WriteLine("Bulunan Kayıt Sayısı"+Ogrenci.Count);
            }
            catch 
            {
                Console.WriteLine("Öğrenci Bulunamadı");
               
            }


        }
    }
}
