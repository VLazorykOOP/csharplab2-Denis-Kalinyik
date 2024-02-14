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

        // Ініціалізуємо мінімальне значення як найбільше можливе, щоб будь-яке додатне число стало кандидатом на мінімум
        int minPositive = int.MaxValue;

        // Пошук мінімуму серед додатних елементів
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0 && numbers[i] < minPositive)
            {
                minPositive = numbers[i];
            }
        }

        // Виведення результату
        if (minPositive != int.MaxValue)
        {
            Console.WriteLine($"Мінімум серед додатних елементів: {minPositive}");
        }
        else
        {
            Console.WriteLine("У масиві немає додатніх елементів.");
        }
    }
}
