using System;

namespace task_5_1_6
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static void Main()
        {
            var arr = GetArrayFromConsole();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
                
            }

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
