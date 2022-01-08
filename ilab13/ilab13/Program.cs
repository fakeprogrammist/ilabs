using System;

namespace ilab13
{
    class Program
    {
        static int min(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 4, 6, 9 };
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                temp = min(temp, array[i]);
            }

            Console.Write("Дан массив: ");
            foreach (var item in array)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine(".\nНаибольшее число в нём: " + temp);
            Console.ReadKey();
        }
    }
}
