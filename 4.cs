
using System;

class Program
{
    static void Main()
    {
        // Введення розмірності масиву
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість елементів у рядку: ");
        int columns = int.Parse(Console.ReadLine());

        // Створення східчастого масиву
        int[,] array = new int[rows, columns];

        // Заповнення масиву випадковими значеннями від 1 до 100
        Random rnd = new Random();
        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = rnd.Next(1, 101); // Генеруємо випадкове число від 1 до 100
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Заміна парних стовпців на вектор X
        Console.WriteLine("\nМасив після заміни парних стовпців:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j % 2 == 0) // Перевіряємо чи номер стовпця парний
                {
                    Console.Write("X\t");
                }
                else
                {
                    Console.Write(array[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}
