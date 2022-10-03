using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "04:59:59AM";

            Console.WriteLine( timeConversion(s));
        }

        public static string timeConversion(string s)
        {
           string[] dizi = s.Split(":");
           decimal hh = Convert.ToInt32(dizi[0]);
            //int mm = Convert.ToInt32(dizi[1]);
            var ss = "";
            var x = "";
            var deger = "";
            if (dizi[2].Contains("AM"))
            {
                ss = dizi[2].Remove(2);
                if (hh == 12 )
                {
                    hh = 0;
                    hh.ToString();
                    x = "0" + hh;
                    deger = string.Format("{0}:{1}:{2}", x, dizi[1], ss);
                }
                else if (hh < 12)
                {
                    deger = string.Format("{0}:{1}:{2}", dizi[0], dizi[1], ss);

                }
            }
            else if (dizi[2].Contains("PM"))
            {
                ss = dizi[2].Remove(2);
                if (hh < 12)
                {
                    hh = hh + 12;
                    hh.ToString();
                    deger = string.Format("{0}:{1}:{2}", hh, dizi[1], ss);
                }
                else
                {
                    
                    //hh.ToString();
                    deger = string.Format("{0}:{1}:{2}", hh, dizi[1], ss);
                }

            }
            
            

          
            return deger;


        }
    }
}
