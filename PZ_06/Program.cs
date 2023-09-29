namespace PZ_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random random = new Random();

            // Заполняем массив случайными числами в интервале [-10..10]
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(arr);

            // Реверс для 1-ой половины массива
            ReverseArray(arr, 0, arr.Length / 2 - 1);

            // Реверс для 2-ой половины массива
            ReverseArray(arr, arr.Length / 2, arr.Length - 1);

            Console.WriteLine("Массив после реверса:");
            PrintArray(arr);
        }

        // Метод для вывода части массива
        static void ReverseArray(int[] arr, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                int temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;

                startIndex++;
                endIndex--;
            }
        }

        // Метод для печати массива
        static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
     }   
}