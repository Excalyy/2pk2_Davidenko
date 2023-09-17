namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write(" Введите текущий день:  ");
            if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
            { Console.WriteLine(" Некорректный ввод дня месяца"); return; }
            int decade;
            switch (day)
            {
                case int n when (n >= 1 && n <= 10):
                    decade = 1; // первая декада
                    break;
                case int n when (n >= 11 && n <= 20):
                    decade = 2; // вторая декада
                    break;
                case int n when (n >= 21 && n <= 31):
                    decade = 3; // третья декада
                    break;
                default:
                    decade = 0;
                    break;
            }
            Console.WriteLine($"Число попадает в {decade} декаду месяца.");
        }
    }
}