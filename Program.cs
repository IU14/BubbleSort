using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {12,15,14,18,9,12,15,4,8,7,5,3,1,4,15,45};

            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int s = 0; s < array.Length - 1; s++)
                {
                    if (array[s] > array [s+1])
                    {
                        temp = array[s + 1];
                        array[s + 1] = array[s];
                        array[s] = temp;
                    }
                }
            }

            int j = 0;
            for (j = 0; j < array.Length; j++)
                Console.Write(array[j] + " ");

            Console.ReadKey();
        }
    }
}
