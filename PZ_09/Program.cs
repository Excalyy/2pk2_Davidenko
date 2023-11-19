using System;

class Program
{
    static void Main()
    {
        // Шаг 1: Ввод строки слов с клавиатуры
        Console.WriteLine("Введите строку слов, разделенных пробелами: ");
        string input = Console.ReadLine();

        // Шаг 2: Разделение строки на отдельные слова
        string[] words = input.Split(' ');

        // Шаг 3: Определение длины самого короткого слова
        int shortestLength = Int32.MaxValue;
        foreach (string word in words)
        {
            if (word.Length < shortestLength)
            {
                shortestLength = word.Length;
            }
        }

        // Шаг 4: Преобразование каждого слова
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Substring(0, shortestLength);
        }

        // Шаг 5: Вывод преобразованной строки
        string result = String.Join(" ", words);
        Console.WriteLine("Преобразованная строка: " + result);
        Console.ReadLine();
    }
}