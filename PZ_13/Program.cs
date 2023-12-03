// Вычисление n-го члена арифметической прогрессии
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int a1 = 55;
        int d = -5;
        int n = 5;
        Console.WriteLine("n-й член арифметической прогрессии: " + ArithmeticProgression(a1, d, n));

        int b1 = 8;
        double q = 0.3;
        Console.WriteLine("n-й член геометрической прогрессии: " + GeometricProgression(b1, q, n));

        int A = 7;
        int B = 12;
        PrintNumbers(A, B);

        int[] arrayA = { 3, 5, 9, 2, 8 };
        int[] arrayB = { 4, 7, 1, 6 };
        int[] arrayC = { 12, 6, 10 };

        Console.WriteLine("Максимальный элемент массива A: " + MaxInt(arrayA, arrayA.Length));
        Console.WriteLine("Максимальный элемент массива B: " + MaxInt(arrayB, arrayB.Length));
        Console.WriteLine("Максимальный элемент массива C: " + MaxInt(arrayC, arrayC.Length));
    }

    // Рекурсивное вычисление n-го члена арифметической прогрессии
    public static int ArithmeticProgression(int a1, int d, int n)
    {
        if (n == 1)
        {
            return a1;
        }
        else
        {
            return ArithmeticProgression(a1, d, n - 1) + d;
        }
    }

    // Рекурсивное вычисление n-го члена геометрической прогрессии
    public static double GeometricProgression(int b1, double q, int n)
    {
        if (n == 1)
        {
            return b1;
        }
        else
        {
            return GeometricProgression(b1, q, n - 1) * q;
        }
    }

    // Рекурсивный вывод чисел от A до B
    public static void PrintNumbers(int A, int B)
    {
        if (A <= B)
        {
            Console.Write(A + " ");
            if (A < B)
            {
                PrintNumbers(A + 1, B);
            }
        }
        else
        {
            Console.Write(A + " ");
            if (A > B)
            {
                PrintNumbers(A - 1, B);
            }
        }
    }

    // Рекурсивное нахождение максимального элемента массива
    public static int MaxInt(int[] A, int N)
    {
        if (N == 1)
        {
            return A[0];
        }
        else
        {
            return Math.Max(A[N - 1], MaxInt(A, N - 1));
        }
    }
}