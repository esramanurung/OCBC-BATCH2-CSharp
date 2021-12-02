using System;


class Assignment1
{
    public static void Main()
    {
        string back = "N", masukan = "";
        do
        {

            Console.WriteLine("Assignment 1\n ");
            Console.WriteLine("Nama : Esra Delima Manurung");
            Console.WriteLine("Nomor Peserta : FSDO002ONL016");
            Console.WriteLine("Domisili : Medan");

            Console.WriteLine("========== List Code Program=========");
            Console.WriteLine(" ");
            Console.WriteLine(" 1.Segitiga Alphabet \n 2.Segitiga Angka \n 3.Factorial \n 4.Reverse Angka \n 5.Convert Angka \n 6.Reverse Kata \n 7.Check Palindrome ");

            Console.WriteLine("");
            Console.Write("Masukan List pilihan Program Yang Diinginkan : ");
            masukan = Console.ReadLine();
            switch (masukan)
            {
                case "1":
                    {
                        int inputan = 0;
                        Console.Write("Enter The Range : ");
                        inputan = int.Parse(Console.ReadLine());

                        char alfabet = 'A';
                        int i, j, k, l;
                        for (i = 1; i <= inputan; i++)
                        {
                            for (j = 1; j <= inputan - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (k = 1; k <= i; k++)
                            {
                                Console.Write(alfabet++);
                            }
                            alfabet--;
                            for (l = 1; l < i; l++)
                            {
                                Console.Write(--alfabet);
                            }
                            Console.WriteLine(" ");
                        }

                        break;
                    }

                case "2":
                    {
                        int inputan = 0;
                        int i, j, k, l;
                        Console.Write("Enter the Range : ");
                        inputan = int.Parse(Console.ReadLine());
                        int firstNumber = 1;


                        for (i = 1; i <= inputan; i++)
                        {
                            for (j = 1; j <= inputan - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (k = 1; k <= i; k++)
                            {
                                Console.Write(firstNumber++);
                            }
                            firstNumber--;
                            for (l = 1; l < i; l++)
                            {
                                Console.Write(--firstNumber);
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    }

                case "3":
                    {
                        int i, number, factorial = 1;
                        Console.Write("Enter any Number: ");
                        number = int.Parse(Console.ReadLine());
                        for (i = 1; i <= number; i++)
                        {
                            factorial *= i;
                        }

                        Console.WriteLine(" Factorial of " + number + " is : " + factorial);
                        break;
                    }

                case "4":
                    {
                        int i, left, reversed = 0;

                        Console.Write("Enter a number: ");
                        i = int.Parse(Console.ReadLine());

                        while (i > 0)
                        {
                            left = i % 10;
                            reversed = reversed * 10 + left;
                            i /= 10;
                        }
                        Console.Write("Reversed Number: " + reversed);
                        break;
                    }

                case "5":
                    {
                        int num, temp = 0, mod;
                        Console.WriteLine("CONTOH PROGRAM KONVERSI ANGKA MENJADI String ");
                        Console.Write("Enter the Number = ");
                        num = int.Parse(Console.ReadLine());
                        while (num > 0)
                        {
                            mod = num % 10;
                            temp = temp * 10 + mod;
                            num = num / 10;
                        }
                        num = temp;
                        while (num > 0)
                        {
                            mod = num % 10;
                            switch (mod)
                            {
                                case 1:
                                    Console.Write("One ");
                                    break;
                                case 2:
                                    Console.Write("Two ");
                                    break;
                                case 3:
                                    Console.Write("Three ");
                                    break;
                                case 4:
                                    Console.Write("Four ");
                                    break;
                                case 5:
                                    Console.Write("Five ");
                                    break;
                                case 6:
                                    Console.Write("Six ");
                                    break;
                                case 7:
                                    Console.Write("Seven ");
                                    break;
                                case 8:
                                    Console.Write("Eight ");
                                    break;
                                case 9:
                                    Console.Write("Nine ");
                                    break;
                                case 0:
                                    Console.Write("Zero ");
                                    break;
                                default:
                                    Console.Write("=====");
                                    break;
                            }
                            num = num / 10;
                        }
                        Console.WriteLine();
                        break;
                    }

                case "6":
                    {
                        string kata = "kasur nababan rusak";
                        string newKata = String.Empty;

                        for (int i = kata.Length; i > 0; i--)
                        {
                            newKata = newKata + kata[i - 1];
                        }
                        Console.WriteLine(newKata);
                        if (kata == newKata)
                        {
                            Console.WriteLine(newKata + " Merupakan Palindrome");
                        }
                        else
                        {
                            Console.WriteLine(newKata + " Bukan Palindrome");
                        }
                        break;
                    }

                case "7":
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
                        Console.WriteLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Pilih List Program Yang Di inginkan");
                        break;
                    }
            }

            Console.Write(" Apakah Ingin Kembali Ke Menu Awal? \t (y/n) :  ");
            back = Console.ReadLine();
            back = back.ToLower();
        }
         while (back == "y");
    }
}
