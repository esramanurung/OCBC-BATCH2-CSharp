using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instant objek
            Laptop laptop1 = new Laptop();

            // akses atribut
            // laptop1.merk = "lenovo";
            // laptop1.ram = 4;
            // laptop1.memory = 128;

            //inputan

            Console.Write("Masukan Merk Laptop:");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukan Kapasitas Ram:");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kapasitas Memory:");
            laptop1.memory = int.Parse(Console.ReadLine());

            //Tampilkan
            Console.WriteLine("\n Merk Laptop adalah{0}, laptop1.merk");
            Console.WriteLine("Kapasitas Ram ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);

            //Akses Method
            laptop1.Chattingan();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();

        }
    }
}

