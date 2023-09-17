namespace PZ_02;
class Program
{
    static void Main(string[] args)
    {
        int c;
        double d;
        Console.Write("Введите значение c: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение d: ");
        d = Convert.ToDouble(Console.ReadLine());
        double n, m, k;
        if (c < 5)
        {
            n = Math.Pow(c, 2) * Math.Sin(c * d) + Math.Sqrt(Math.Abs(c));
        }
        else
        {
            n = d * Math.Cos(c * d) + 1 / Math.Sqrt(Math.Abs(c));
        }
        if (n <= 2)
        {
            m = Math.Exp(c) + Math.Pow(Math.Sin(n), 2) + d;
        }
        else
        {
            m = c * Math.Cos(5 / n - 3);
        }
        k = 20 * d + 10 * n - m + n / 2;
        Console.WriteLine($"Значение n: {n}");
        Console.WriteLine($"Значение m: {m}");
        Console.WriteLine($"Значение k: {k}");

        Console.ReadLine();
    }
}