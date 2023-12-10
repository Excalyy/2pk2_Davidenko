using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Запросить у пользователя полный путь к каталогу
            Console.WriteLine("Введите полный путь к каталогу:");
            string directoryPath = Console.ReadLine();

            // Получить размер каталога
            long directorySize = GetDirectorySize(directoryPath);
            Console.WriteLine($"Размер каталога: {directorySize} байт");

            // Проверка на превышение 10 Мб
            if (directorySize > 10 * 1024 * 1024)
            {
                // Получить путь к самому большому файлу
                string largestFilePath = GetLargestFile(directoryPath);
                if (!String.IsNullOrEmpty(largestFilePath))
                {
                    // Удалить самый большой файл
                    File.Delete(largestFilePath);
                    Console.WriteLine($"Самый большой файл ({largestFilePath}) удален");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    // Метод для получения размера каталога
    static long GetDirectorySize(string path)
    {
        string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        long size = 0;
        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            size += fileInfo.Length;
        }
        return size;
    }

    // Метод для получения пути к самому большому файлу
    static string GetLargestFile(string path)
    {
        string largestFilePath = "";
        long maxSize = 0;
        string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            if (fileInfo.Length > maxSize)
            {
                maxSize = fileInfo.Length;
                largestFilePath = fileInfo.FullName;
            }
        }
        return largestFilePath;
    }
}