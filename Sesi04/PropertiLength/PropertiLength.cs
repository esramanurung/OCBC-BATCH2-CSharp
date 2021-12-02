
using System;


public class PropertiLength
{
    public static void Main(string[] args)
    {
        int[] angka = new int[10];
        Console.WriteLine("Panjang array angka adalah " + angka.Length);

        //Menggunakan Length untuk Menginisialisasi angka.
        for(int i = 0; i < angka.Length; i++)
        angka[i] = i * i;

        //Sekarang menggunakan length untuk menampilkan angka.
        Console.Write("Berikut adalah array anggka: ");
        for(int i = 0; i < angka.Length; i++)
        Console.Write(angka[i] + " ");

        Console.WriteLine();

    }
}

