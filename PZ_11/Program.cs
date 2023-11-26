using System;

class Program
{
    // Описываем процедуру SqlrtA234
    static void SqlrtA234(double A, out double B, out double C, out double D)
    {
        B = Math.Pow(A, 1.0 / 2.0); // Корень второй степени числа A
        C = Math.Pow(A, 1.0 / 3.0); // Корень третьей степени числа A
        D = Math.Pow(A, 1.0 / 4.0); // Корень четвертой степени числа A
    }

    static void Main()
    {
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введите число: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Находим вторую, третью и четвертую степени для введенных чисел
        for (int i = 0; i < 5; i++)
        {
            double B, C, D;
            SqlrtA234(numbers[i], out B, out C, out D);
            Console.WriteLine($"Для числа {numbers[i]}:");
            Console.WriteLine($"B = {B} - корень второй степени числа");
            Console.WriteLine($"C = {C} - корень третьей степени числа");
            Console.WriteLine($"D = {D} - корень четвертой степени числа");
            Console.WriteLine("Нажмите enter");
            Console.ReadLine();
        }
    }
}