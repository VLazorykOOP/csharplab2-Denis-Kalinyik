using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків масиву: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців масиву: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] numbers = new int[rows, columns];

        // Заповнення масиву введеними користувачем числами
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введіть число для елемента [{i},{j}]: ");
                numbers[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Елементи масиву, які не діляться на 7:");

        // Перебір всіх елементів масиву
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Перевірка чи число не ділиться на 7
                if (numbers[i, j] % 7 != 0)
                {
                    // Вивід номера елемента, який не ділиться на 7
                    Console.WriteLine($"Елемент з індексами [{i},{j}]: {numbers[i, j]}");
                }
            }
        }
    }
}
