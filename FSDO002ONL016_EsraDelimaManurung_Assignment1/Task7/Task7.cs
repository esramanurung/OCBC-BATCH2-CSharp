using System;

class Task7
{
    public static void Main()
    {
        Console.Write("Enter a string to Check Palindrome : ");
        string name = Console.ReadLine();
        char[] nameArray = name.ToCharArray();
        Array.Reverse(nameArray);
        string reverse = new string(nameArray);

        if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{name} is Palindrome");
        }
        else
        {
            Console.WriteLine($"{name} is not Palindrome");
        }
        Console.ReadKey();
    }

}
