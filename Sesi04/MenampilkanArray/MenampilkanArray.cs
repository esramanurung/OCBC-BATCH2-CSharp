using System;


public class MenampilkanArray
{
    public static void Main(string[] args)
    {
        string[] contoh = new string[4]
        {
            "Motherboard","Processor","Power Supply", "Video Card"
        };
        Console.WriteLine("Menampilkan Semua data dalam Array");
        Console.WriteLine("");
        foreach(string contoh1 in contoh){
            Console.WriteLine(contoh1);
        }
        Console.Write("Press any Key to continue ...");

    }
}

