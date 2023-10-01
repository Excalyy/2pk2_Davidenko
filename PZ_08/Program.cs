namespace PZ_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание ступенчатого массива
            Random random = new Random();
            int[][] staircaseArray = new int[4][];
            for (int i = 0; i < staircaseArray.Length; i++)
            {
                int length = random.Next(5, 16);
                staircaseArray[i] = new int[length];
                for (int j = 0; j < staircaseArray[i].Length; j++)
                {
                    staircaseArray[i][j] = random.Next(1, 101); // Заполнение значениями от 1 до 100
                }
            }

            // Вывод сгенерированного массива
            Console.WriteLine("Сгенерированный массив:");
            foreach (var row in staircaseArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // Создание нового одномерного массива и запись последних элементов каждой строки
            int[] lastElements = new int[staircaseArray.Length];
            for (int i = 0; i < staircaseArray.Length; i++)
            {
                lastElements[i] = staircaseArray[i][staircaseArray[i].Length - 1];
            }

            // Вывод нового массива с последними элементами
            Console.WriteLine("\nМассив последних элементов:");
            Console.WriteLine(string.Join(" ", lastElements));

            // Поиск максимального элемента в каждой строке и запись их в другой массив
            int[] maxElements = new int[staircaseArray.Length];
            for (int i = 0; i < staircaseArray.Length; i++)
            {
                maxElements[i] = staircaseArray[i].Max();
            }

            // Вывод массива с максимальными элементами
            Console.WriteLine("\nМассив максимальных элементов:");
            Console.WriteLine(string.Join(" ", maxElements));

            // Обновление массива, меняя местами первый элемент и максимальный в каждой строке
            for (int i = 0; i < staircaseArray.Length; i++)
            {
                int maxIndex = Array.IndexOf(staircaseArray[i], maxElements[i]);
                int temp = staircaseArray[i][0];
                staircaseArray[i][0] = staircaseArray[i][maxIndex];
                staircaseArray[i][maxIndex] = temp;
            }

            // Вывод обновленного массива
            Console.WriteLine("\nОбновленный массив:");
            foreach (var row in staircaseArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // Реверс каждой строки ступенчатого массива
            for (int i = 0; i < staircaseArray.Length; i++)
            {
                Array.Reverse(staircaseArray[i]);
            }

            // Вывод массива после выполнения реверса
            Console.WriteLine("\nМассив после реверса:");
            foreach (var row in staircaseArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // Подсчет среднего значения, общего количества символов и наиболее встречающихся символов
            Console.WriteLine("\nРезультаты подсчета:");
            for (int i = 0; i < staircaseArray.Length; i++)
            {
                if (staircaseArray[i].Length > 0 && staircaseArray[i][0] >= 0 && staircaseArray[i][0] <= 100)
                {
                    double average = staircaseArray[i].Average();
                    Console.WriteLine($"Среднее значение в строке {i + 1}: {average}");
                }
                else if (staircaseArray[i].Length > 0 && staircaseArray[i][0] >= 'a' && staircaseArray[i][0] <= 'z')
                {
                    int totalChars = 0;
                    char[] chars = new char[26];
                    foreach (var num in staircaseArray[i])
                    {
                        totalChars += num.ToString().Length;
                        chars[num - 'a']++;
                    }
                    Console.WriteLine($"Общее количество символов в строке {i + 1}: {totalChars}");
                    Console.WriteLine($"Наиболее встречающиеся символы в строке {i + 1}:");
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if (chars[j] > 0)
                        {
                            Console.WriteLine($"{(char)(j + 'a')}: {chars[j]}");
                        }
                    }
                }
            }
        }
    }
}