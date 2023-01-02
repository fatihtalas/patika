// See https://aka.ms/new-console-template for more information
using System;

namespace c101odev1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soru numarasını giriniz.");
            string soru=Console.ReadLine();
            switch (soru)
            {
                case "1":
                soru1();
                break;
                case "2":
                soru2();
                break;
                case "3":
                soru3();
                break;
                case "4":
                soru4();
                break;           
            }
        }
        static void soru1()
        {
            Console.WriteLine("Soru 1:");
            Console.WriteLine("Pozitif bir sayı giriniz.");
            int sayi=0;
            try
            {
            sayi=Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz veri.");
                soru1();
            }
            int[] dizi=new int[sayi];
            for(int i=0;i<dizi.Length;i++)
            {
                try
            {
                Console.WriteLine("{0}. sayıyı giriniz.",i+1);
            dizi[i]=Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz veri tekrar giriniz.");
                i--;
            }
            }
            for(int i=0;i<dizi.Length;i++)
            {
                if(dizi[i]%2==0)
                Console.WriteLine(dizi[i]);
            }
        }
        static void soru2()
        {
            Console.WriteLine("Soru 2:");
            int sayi1=0,sayi2=0;
            try
            {
                Console.WriteLine("1. Sayıyı giriniz.");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz.");
            sayi2=Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz veri.");
                soru2();
            }

            int[] dizi=new int[sayi1];
            for(int i=0;i<dizi.Length;i++)
            {
                try
            {
                Console.WriteLine("Dizinin {0}. sayısını giriniz.",i+1);
            dizi[i]=Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz veri tekrar giriniz.");
                i--;
            }
            }
            for(int i=0;i<dizi.Length;i++)
            {
                if(dizi[i]%sayi2==0)
                Console.WriteLine(dizi[i]);
            }

        }
        static void soru3()
        {
            Console.WriteLine("Soru 3:");
            Console.WriteLine("Pozitif bir sayı giriniz.");
            int sayi=0;
            try
            {
            sayi=Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Geçersiz veri.");
                soru3();
            }
            string[] dizi=new string[sayi];
            for(int i=0;i<dizi.Length;i++)
            {
             
                Console.WriteLine("{0}. kelimeyi giriniz.",i+1);
                dizi[i]=Console.ReadLine();
            
            }
            for(int i=dizi.Length-1;i>=0;i--)
            {                
                Console.WriteLine(dizi[i]);
            }
        }
        static void soru4()
        {
            Console.WriteLine("Soru 4:");
            Console.WriteLine("Bir cümle yazınız.");
            string cumle=Console.ReadLine();
            string[] dizi=cumle.Split(" ");
            Console.WriteLine("Bu cümle {0} kelimeden oluşur.",dizi.Length);
            string yenicumle=String.Join("",dizi);
            Console.WriteLine("Bu cümle {0} harften oluşur.",yenicumle.Length);
        }
    }
}
