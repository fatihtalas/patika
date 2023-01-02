// See https://aka.ms/new-console-template for more information
using System;

namespace donguler_while_foreach // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            // int sayi=int.Parse(Console.ReadLine());
            // int sayac=1,toplam=0;
            // while(sayac<=sayi)
            // {
            //     toplam+=sayac;
            //     sayac++;
            // }
            // Console.WriteLine(toplam/sayi);

            // char character='a';
            // while(character<'z')
            // {
            //     Console.WriteLine(character);
            //     character++;
            // }

            Console.WriteLine("*****Foreach*****");
            string[] arabalar={"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}