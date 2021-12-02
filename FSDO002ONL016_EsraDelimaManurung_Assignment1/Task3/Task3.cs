using System;


public class Task3
{
    public static void Main(string[] args)
    {
        int i,number, factorial = 1;
        Console.Write("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++){
            factorial *= i;
        }
       
            Console.WriteLine(" Factorial of " + number +" is : " +factorial);
        
    }
}
