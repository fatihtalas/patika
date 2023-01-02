using System;

namespace donguler_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Lutfen bir sayı giriniz.");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if(i%2==1)
                Console.WriteLine(i);
            }
            int tektoplam=0, cifttoplam=0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2==1)   
                tektoplam=tektoplam+i;
                else
                cifttoplam=cifttoplam+i;             
            }

            Console.WriteLine("Tek Toplam:"+tektoplam.ToString());
            Console.WriteLine("Çift Toplam:"+cifttoplam.ToString()); */
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }
             for (int i = 0; i < 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
            }
        }
    }
}