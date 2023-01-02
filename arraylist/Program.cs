// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace arraylist // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste=new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('a');
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //   Console.WriteLine(item);
            //}

            Console.WriteLine("Add Range");
            //string[] renkler={"kırmızı","yeşil","mavi"};
            List<int> sayilar=new List<int>(){1,8,3,7,9,92,5};

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sort");
            liste.Sort();
             foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Binary Search");
            Console.WriteLine(liste.BinarySearch(9));
            Console.WriteLine("Reverse");
            liste.Reverse();
              foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
                }
    }
}