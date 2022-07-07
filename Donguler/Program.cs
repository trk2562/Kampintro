using System;

namespace Donguler
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"Yazılımcı geliştirici yetiştirme kampı",
                "programlamaya başlangıç için temel kurs",
                "java"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti.");
            foreach (string kurs in kurslar) //foreach dizi temelli yapıları tek tek dönmeye yarar.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach Bitti.");
        }

    }
}