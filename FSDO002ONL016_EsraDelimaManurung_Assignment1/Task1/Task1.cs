using System;


public class Task1
{
    public static void Main(string[] args)
    {
        int inputan = 0;
        Console.Write("Enter The Range : ");
        inputan = int.Parse(Console.ReadLine());

        char alfabet = 'A';
        int i, j, k, l;
        for (i = 1; i <= inputan; i++)
        {
            //sisi kosong
            for (j = 1; j <= inputan - i; j++)
            {
                Console.Write(" ");
            }
            //sisi kiri
            for (k = 1; k <= i; k++)
            {
                Console.Write(alfabet++);
            }
            alfabet--;
            //sisi kanan
            for (l = 1; l < i; l++)
            {
                Console.Write(--alfabet);
            }
            Console.WriteLine(" ");
        }
    }
}
