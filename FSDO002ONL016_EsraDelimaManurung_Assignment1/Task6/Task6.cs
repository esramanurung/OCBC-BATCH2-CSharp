using System;

class Task6
{
    public static void Main()
    {
        //Program Refers Kata
       string kata = "kasur nababan rusak";
       string newKata = String.Empty;

       for(int i = kata.Length; i > 0; i--){
           newKata = newKata+kata[i-1];
       }
       Console.WriteLine(newKata);
       if(kata == newKata){
           Console.WriteLine(newKata + " Merupakan Palindrome");
       }
       else{
           Console.WriteLine(newKata + " Bukan Palindrome");
       }
    }

}

