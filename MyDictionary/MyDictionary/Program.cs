using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDictionary<int, string> myDictionary= new MyDictionary<int, string>();
            //myDictionary.Add(1, "Kamil Başer");
            //myDictionary.Add(2, "Adile Başer");

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Düriye Güğümlerikalaylı");
            myDictionary.Add(2, "Kamil Deneme");
            myDictionary.Add(3, "Ayşe Deneme");
            Console.WriteLine($"Eklenen Veri Sayısı: {myDictionary.Count}");
            
        }
    }
}
