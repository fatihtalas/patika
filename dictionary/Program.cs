// See https://aka.ms/new-console-template for more information
using System;

namespace dictionary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar=new Dictionary<int, string>{};

            kullanicilar.Add(10,"Ayşe Yılmaz");
            kullanicilar.Add(12,"Ahmet Yılmaz");
            kullanicilar.Add(18,"Deniz Arda");
            kullanicilar.Add(20,"Özcan Coşar");

            Console.WriteLine("****Elemanlara Erişim****");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****Count****");
            Console.WriteLine(kullanicilar.Count);
            Console.WriteLine("****Contains****");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

            Console.WriteLine("****Remove****");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****Keys****");
            
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****Values****");
            
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
