// See https://aka.ms/new-console-template for more information
using System;

namespace overloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi="999";
            bool sonuc=int.TryParse(sayi,out int outsayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outsayi);
            }
            else
            Console.WriteLine("Başarısız");
            Metotlar instance=new Metotlar();
            instance.Topla(4,5,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);

            int ifade=999;
            instance.ekranayazdir(ifade.ToString());
            instance.ekranayazdir(ifade);
            instance.ekranayazdir("Fatih","Talas");

        }
    }
    class Metotlar
    {
        public void Topla(int a,int b,out int toplam)
        {
            toplam=a+b;
        }

        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
         public void ekranayazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}