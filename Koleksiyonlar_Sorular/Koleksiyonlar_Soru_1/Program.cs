// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace Koleksiyonlar_soru_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal=new ArrayList();
            ArrayList asaldegil=new ArrayList();
            for(int i=0;i<20;i++)
            {
                Console.WriteLine("Sayı Giriniz.");
                try
                {
                    int sayi=Convert.ToInt32(Console.ReadLine());
                    if(asalmi(sayi))
                    asal.Add(sayi);
                    else
                    asaldegil.Add(sayi);
                }
                catch
                {
                    Console.WriteLine("Sayısal değer girmediniz");
                    i--;
                }
            }
            
            asal.Sort(new DescendingIntSorter());
int asaltoplam=0,asaldegiltoplam=0;
Console.WriteLine("Asal Sayılar");
foreach (var x in asal)
{
    Console.WriteLine(x.ToString());
    asaltoplam=asaltoplam+Convert.ToInt32(x);
}
asaldegil.Sort(new DescendingIntSorter());
Console.WriteLine("Asal Olmayan Sayılar");
foreach (var x in asaldegil)
{
    Console.WriteLine(x.ToString());
    asaldegiltoplam=asaldegiltoplam+Convert.ToInt32(x);
}
        Console.WriteLine("Asal Eleman Sayısı:{0}",asal.Count);
        Console.WriteLine("Asal Olmayan Eleman Sayısı:{0}",asaldegil.Count);
        Console.WriteLine("Asal Ortalama:{0}",asaltoplam/asal.Count);
        Console.WriteLine("Asal Olmayan Ortalama:{0}",asaldegiltoplam/asaldegil.Count);
        }
        public class DescendingIntSorter : System.Collections.IComparer
{
    public int Compare(object x, object y)
    {
        return ((int)y).CompareTo((int)x);
    }
}
        static bool asalmi(int sayi)
        {
            if(sayi==1)
            return true;
            for(int i=2;i<sayi+1;i++)
            {
                if(i==sayi)
                continue;
                if(sayi%i==0)
                return false;
            }
            return true;
        }
        
    }
    
}
