using System;


public class TaskPertama
{
    public static void Main(string[] args)
    {
        String Username;
        String Password;
        Console.Write("Enter your Username: ");
        Username = Console.ReadLine();
        Console.Write("Enter your Password: ");
        Password = Console.ReadLine();

        if (Username == "ocbc" && Password == "bootcamp")
        {
            Console.WriteLine("Anda Berhasil Login");
            
            
        }
        else
        {
             Console.WriteLine("Username atau Password Anda Salah");
        }

    }
}

// --
// using System;


// public class Loop2
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter your Username: ");
//         string username = Console.ReadLine();
//         Console.Write("Enter your Password: ");
//         string password = Console.ReadLine();

//         string usernameInput = "ocbc";
//         string passwordInput = "bootcamp";


//         if (usernameInput != "ocbc" && passwordInput != "bootcamp")
//         {
//             Console.WriteLine("Username atau Password Anda Salah");
            
//         }
//         else
//         {
//             Console.WriteLine("Anda Berhasil Login");
//         }

//     }
// }


