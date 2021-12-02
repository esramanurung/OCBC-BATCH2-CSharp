using System;

class Soal5
{
    public static void Main()
    {
       int num,temp = 0,mod ;     
       Console.WriteLine("CONTOH PROGRAM KONVERSI ANGKA MENJADI String ");
       Console.Write("Enter the Number = ");    
       num= int.Parse(Console.ReadLine());     
       while(num > 0)      
       {      
            mod = num % 10;      
            temp = temp * 10 + mod;      
            num = num / 10;      
       }      
       num = temp;      
       while(num > 0)      
       {      
            mod = num % 10;      
            switch(mod)      
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
    }  
  }  