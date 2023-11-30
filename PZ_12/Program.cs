using System;

public class Program
{
    public static double[,] GenerateRandomArray(int a, int b)
    {
        double[,] result = new double[a, b];
        Random random = new Random();

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                double randomValue = Math.Round(random.NextDouble() * 20 - 10, 2);
                result[i, j] = randomValue;
            }
        }

        return result;
    }

    public static void Main()
    {
        Console.WriteLine("Введите количество рядов (a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Итоговая таблица: ");
        double[,] array = GenerateRandomArray(a, b);

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}