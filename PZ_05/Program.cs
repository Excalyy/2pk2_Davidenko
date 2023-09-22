namespace PZ_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N:");
            int N = int.Parse(Console.ReadLine());

            bool isPowerOfThree = IsPowerOfThree(N);

            Console.WriteLine(isPowerOfThree);
        }

        static bool IsPowerOfThree(int N)
        {
            while (N % 3 == 0)
            {
                N /= 3;
            }

            return N == 1;
        }
     }   
}