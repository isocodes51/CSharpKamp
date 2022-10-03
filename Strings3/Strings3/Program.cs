using System;

namespace Strings3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tekrar sayısını gir");
            int t = Convert.ToInt32(Console.ReadLine());
            

            for (int b = 0; b < t; b++)
            {
                Console.WriteLine("Değer gir:");
                string s = Console.ReadLine().ToString();
                string[] arr = { s };
                foreach (string ss in arr)
                {
                    for (int ix = 0; ix < ss.Length; ix++)
                    {
                        if (ix % 2 == 0)
                        {
                            Console.Write(ss[ix]);
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

                    Console.WriteLine(" ");
                }
            }
        }
    }
}
