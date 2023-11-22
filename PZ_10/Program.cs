using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        string[] words = inputText.Split(' ');

        string invertedText = "";

        foreach (string word in words)
        {
            int wordLength = word.Length;
            string invertedWord = "";

            for (int i = wordLength - 1; i >= 0; i--)
            {
                invertedWord += word[i];
            }

            invertedText += invertedWord;

            if (word != words[words.Length - 1])
            {
                invertedText += " ";
            }
        }

        Console.WriteLine("Инвертированный текст:");
        Console.WriteLine(invertedText);
        Console.ReadLine();
    }
}