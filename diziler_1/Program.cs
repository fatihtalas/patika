// See https://aka.ms/new-console-template for more information
using System;

namespace diziler_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler=new string[5];
            string[] hayvanlar={"Kedi","Köpek","Kuş","Maymun"};
            int[] dizi;
            dizi=new int[5];

            renkler[0]="Mavi";
            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziuzunlugu=int.Parse(Console.ReadLine());
            int [] sayidizisi=new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz",i+1);
                sayidizisi[i]=int.Parse(Console.ReadLine());    
            }

            int toplam=0;
            foreach (var sayi in sayidizisi)
            {
                toplam+=sayi;    
            }
            Console.WriteLine("Ortalama:"+toplam/diziuzunlugu);
        }
    }
}
