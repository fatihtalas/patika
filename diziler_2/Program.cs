// See https://aka.ms/new-console-template for more information
using System;

namespace diziler_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayidizisi={23,12,4,86,72,3,11,17};

            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Array Clear");
            Array.Clear(sayidizisi,2,2);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Array Reverse");
            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Array Indexof");
            Console.WriteLine(Array.IndexOf(sayidizisi,23));
            
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayidizisi,9);
            sayidizisi[8]=99;
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
