using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність матриці (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        // Заповнення матриці введеними користувачем числами
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Введіть елемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Перевірка симетрії матриці відносно головної діагоналі
        bool isSymmetric = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Перевірка чи елемент [i, j] дорівнює елементу [j, i]
                if (matrix[i, j] != matrix[j, i])
                {
                    isSymmetric = false;
                    break;
                }
            }
            if (!isSymmetric)
            {
                break;
            }
        }

        // Виведення результату
        if (isSymmetric)
        {
            Console.WriteLine("Матриця є симетричною відносно головної діагоналі.");
        }
        else
        {
            Console.WriteLine("Матриця не є симетричною відносно головної діагоналі.");
        }
    }
}
