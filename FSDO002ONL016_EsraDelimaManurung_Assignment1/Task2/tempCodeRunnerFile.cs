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