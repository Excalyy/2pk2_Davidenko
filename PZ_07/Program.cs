namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] arr = new int[5, 5];

            // Заполнение матрицы случайными числами
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = random.Next(100);
                }
            }

            int maxElement = arr[0, 0];
            int maxIndexRow = 0;
            int maxIndexCol = 0;

            // Находим максимальный элемент и его индексы
            for (int i = 0; i < 5; i++)
            {
                if (arr[i, i] > maxElement)
                {
                    maxElement = arr[i, i];
                    maxIndexRow = i;
                    maxIndexCol = i;
                }
            }

            // Выводим результаты
            Console.WriteLine("Максимальный элемент главной диагонали матрицы: " + maxElement);
            Console.WriteLine("Индексы максимального элемента: (" + maxIndexRow + ", " + maxIndexCol + ")");

            Console.ReadLine();
        }
}   }