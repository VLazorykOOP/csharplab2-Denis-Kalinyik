
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність масиву: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        // Заповнення масиву введеними користувачем числами
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введіть число для елемента {i}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Елементи масиву, які не діляться на 7:");

        // Перебір всіх елементів масиву
        for (int i = 0; i < numbers.Length; i++)
        {
            // Перевірка чи число не ділиться на 7
            if (numbers[i] % 7 != 0)
            {
                // Вивід номера елемента, який не ділиться на 7
                Console.WriteLine($"Елемент з індексом {i}: {numbers[i]}");
            }
        }
    }
}

