using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibo = { 1, 1, 2, 3, 5, 8 };

            foreach(int num in fibo)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
