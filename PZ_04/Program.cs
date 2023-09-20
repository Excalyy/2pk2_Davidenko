namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //первое задание
            int i; 
            Console.WriteLine("Первое задание");
            for (i = 20; i <= 80; i += 5)
            {
             Console.WriteLine(i);
            }
            //второе задание
            Console.WriteLine("Второе задание");
            char start = 'G';
            for (int b = 0; b < 5; b++)
            {
            Console.WriteLine(start);
            start++;
            }
            //третье задание
            Console.WriteLine("Третье задание");
            string h = "#####";
            {
            for (int c = 0; c < 6; c++)
            {
            Console.WriteLine(h);
            }
            //четвёртое задание
            int e = 0; int q = 0;
            Console.WriteLine("Четвёртное задание"); 
            for (e = -900; e <= 500; e++)
            if (e % 6 == 0)
            {
            Console.Write(e + " "); q++;
            }
            Console.WriteLine("\nКоличество чисел, кратных 6: " + q);
            //пятое задание 
            Console.WriteLine("Пятое задание");
            int g = 4; int j = 40;
            while (Math.Abs(g - j) > 24)
            {
            Console.WriteLine($"i = {g}, j = {j}");
            g++; j--;
            }
            Console.WriteLine("Все задания выполнены");
            }

        }
    }
}