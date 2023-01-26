using System;

namespace Shuffle
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            
            Console.WriteLine(string.Join(" ", array));
            ShuffleArray(array);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void ShuffleArray(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int randomIndex = random.Next(array.Length);
                    (array[j], array[randomIndex]) = (array[randomIndex], array[j]);
                }
            }
        }
    }
}
