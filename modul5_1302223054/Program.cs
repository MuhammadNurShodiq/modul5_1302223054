using System;
using System.Security.Cryptography.X509Certificates;
using static Program;

internal class Program
{
    public class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T satu, T dua, T tiga)
        {
            dynamic a = satu;
            dynamic b = dua;
            dynamic c = tiga;

            return a + b + c;

        }

    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 22, 23));
    }
}