namespace PZ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу решения линейной задачи!");

            double a = 1;
            double b = Math.PI / 2;
            double c = 2;

            // Вычислим значения корня, синуса и косинуса
            double root = Math.Sqrt(Math.Abs(a * b * c / 2.4));
            double sinB = Math.Sin(b);
            double cosB = Math.Cos(b);

            // Решим линейную задачу используя заданные формулы
            double result = (root * a * b * c / 2.4) - (0.7 * a * b * c / sinB) + (Math.Pow(10, 4) * 5 * root * Math.Abs(cosB)) - Math.Abs(b - a) / 7.5;

            Console.WriteLine("Результат решения линейной задачи: " + result);

            Console.ReadLine();
        }
    }
}