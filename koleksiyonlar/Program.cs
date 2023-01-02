// See https://aka.ms/new-console-template for more information
using System;

namespace koleksiyonlar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi=new List<int>{};
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi=new List<string>{};
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
             foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            if(sayiListesi.Contains(10))
            Console.WriteLine("10 bulundu");
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            string[] hayvanlar={"Kedi","Köpek","Kuş"};
            List<string> hayvanlistesi=new List<string>(hayvanlar);

            hayvanlistesi.Clear(); 
            List<Kullanıcılar> kullanicilistesi=new List<Kullanıcılar>{};
            Kullanıcılar kullanici1=new Kullanıcılar();
            kullanici1.Isim="Ayşe";
            kullanici1.Soyisim="Koruk";
            kullanici1.Yas=26;

            Kullanıcılar kullanici2=new Kullanıcılar();
            kullanici2.Isim="Özcan";
            kullanici2.Soyisim="Gübeş";
            kullanici2.Yas=22;

            kullanicilistesi.Add(kullanici1);
            kullanicilistesi.Add(kullanici2);

            List<Kullanıcılar> yeniliste=new List<Kullanıcılar>{};
            yeniliste.Add(new Kullanıcılar()
            {
                Isim="Deniz",
                Soyisim="Arda",
                Yas=25
            });

            foreach (var kullanici in kullanicilistesi)
            {
                Console.WriteLine(kullanici.Isim);
                Console.WriteLine(kullanici.Soyisim);
                Console.WriteLine(kullanici.Yas);                
            }

            yeniliste.Clear();
        }


    }
    
}
public class Kullanıcılar
{
    string isim;
    string soyisim;
    int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}
