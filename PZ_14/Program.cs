using System;
using System.IO;

class Program
{
    static void Main()
    {
        var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); // путь к файлу на рабочем столе
        var filePath = Path.Combine(desktopPath, "inFile.txt"); // путь к файлу на рабочем столе

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath)) // открываем файл для записи
            {
                Console.WriteLine("Введите текст (для завершения введите пустую строку):");

                string input = Console.ReadLine(); // считываем данные с консоли

                while (!string.IsNullOrEmpty(input)) // пока строка не пустая
                {
                    writer.WriteLine(input); // записываем строку в файл
                    input = Console.ReadLine(); // считываем следующую строку с консоли
                }
            }

            using (StreamReader reader = new StreamReader(filePath)) // открываем файл для чтения
            {
                string fileContent = reader.ReadToEnd(); // считываем содержимое файла
                Console.WriteLine($"Содержимое файла {filePath}:");
                Console.WriteLine(fileContent); // выводим содержимое файла
                int count = CountNumbers(fileContent); // считаем количество чисел в тексте
                Console.WriteLine($"Количество чисел в тексте: {count}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static int CountNumbers(string text)
    {
        int count = 0;
        string[] words = text.Split(' '); // разбиваем текст на слова

        foreach (string word in words)
        {
            if (int.TryParse(word, out _)) // пытаемся преобразовать слово в число
            {
                count++; // если успешно, увеличиваем счётчик
            }
        }

        return count;
    }
}