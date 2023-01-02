// See https://aka.ms/new-console-template for more information
using System;

namespace metotlar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=2,b=3;
            Console.WriteLine(a+b);

            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);
            Metotlar ornek=new Metotlar();
            ornek.ekranayaz(sonuc.ToString());

            int sonuc2=ornek.arttirvetopla(ref a,ref b);
            ornek.ekranayaz(sonuc2.ToString());
            ornek.ekranayaz(Convert.ToString(a+b));
        }
        static int Topla(int deger1,int deger2)
        {
            return (deger1+deger2);
        }
        
    }
    class Metotlar
    {
        public void ekranayaz(string veri)
        {
            Console.WriteLine(veri);
        }
        public int arttirvetopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}