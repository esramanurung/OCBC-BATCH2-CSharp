using System;

class Task4
{
    public static void Main()
    {
        int  i, left,reversed = 0;

        Console.Write("Enter a number: ");      
        i= int.Parse(Console.ReadLine());

        while(i>0)      
        {      
            left = i % 10;        
            reversed = reversed * 10 + left;      
            i/=10;      
        }      
       Console.Write("Reversed Number: "+reversed);       
    }
}