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

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("1", "Düriye Güğümlerikalaylı");
            Console.WriteLine($"Eklenen Veri Sayısı: {myDictionary.Count}");
            
        }
    }

    class MyDictionary<K, V>
    {
        K[] _arr1,_tempArr1;
        V[] _arr2, _tempArr2;
        
        public MyDictionary()
        {
            _arr1 = new K[0];
            _arr2 = new V[0];
        }
        public void Add(K num,V val)
        {
            _tempArr1 = _arr1;
            _tempArr2 = _arr2; 
            _arr1 = new K[_arr1.Length + 1];
            _arr2 = new V[_arr2.Length + 1];
            for(int i = 0; i < _tempArr1.Length; i++)
            {
                _arr1[i] = _tempArr1[i];
                _arr2[i] = _tempArr2[i];
            }
            _arr1[_arr1.Length - 1] = num;
            _arr2[_arr2.Length - 1] = val;

            Console.WriteLine($"{num} numaralı {val} eklendi");
            
        }

        

        public int Count
        {
            get { return _arr1.Length; }
           
        }

       
    } 
}
