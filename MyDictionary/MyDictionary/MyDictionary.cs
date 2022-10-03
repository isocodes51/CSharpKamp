using System;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] _arr1,_tempArr1;
        V[] _arr2, _tempArr2;
        
        public MyDictionary()
        {
            _arr1 = new K[0];
            _arr2 = new V[0];
        }
        public void Add(K key,V value)
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
            _arr1[_arr1.Length - 1] = key;
            _arr2[_arr2.Length - 1] = value;

            Console.WriteLine($"{key} numaralı {value} eklendi");
            
        }

        

        public int Count
        {
            get { return _arr1.Length; }
           
        }

       
    } 
}
