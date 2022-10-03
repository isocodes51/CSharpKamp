using System;
using System.Linq;
using System.Xml.Linq;

namespace WosDeneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlx = "https://wos-api.clarivate.com/api/woslite/?databaseId=WOS&usrQuery=TS%3D%28cadmium%29&count=5&firstRecord=1";
            string api = "6b46ffda86a7a3e9aa2336cd846bfd5f09e18708";
            XDocument res = XDocument.Load(urlx);
           
            var tmp = res.Descendants("Author").ElementAt(0).Attribute("Authors");
            Console.WriteLine(tmp);
            Console.ReadLine();
        }
    }
}
