using System;


public class Loop3
{
    public static void Main(string[] args)
    {
        double Nilai;
        Console.Write("Nilai: ");
        Nilai = Convert.ToDouble(Console.ReadLine());

        if(Nilai >= 85)
        {
             Console.WriteLine("Kamu Mendapat Grade A");
        }
        
        else if(Nilai >= 65)
        {
             Console.WriteLine("Kamu Mendapat Grade B");
        }
        else if(Nilai >= 45)
        {
             Console.WriteLine("Kamu Mendapat Grade C");
        }
        else if(Nilai < 25)
        {
             Console.WriteLine("Kamu Mendapat Grade D");
        }
    
    }
}