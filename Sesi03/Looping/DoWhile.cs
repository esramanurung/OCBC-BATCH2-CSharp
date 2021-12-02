using System;


public class DoWhile
    {
        public static void Main(string[] args)
        {
            // Membuat Variable
            int i = 0;
            
            // do while
            do{
                Console.WriteLine("i = {0} ", i);
                i++;

                if(i > 5)
                break;
            }
            while( i< 10);
            
        }
    }

