using System;

namespace task_5_1_6
{
    class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(params int[] getArrayFromConsole)
        {
            var sortArr = getArrayFromConsole;
            for (int i = 0; i < sortArr.Length; i++)
            {
                for (int j = i + 1; j < sortArr.Length; j++)
                {
                    if (sortArr[i] > sortArr[j])
                    {
                        (sortArr[i], sortArr[j]) = (sortArr[j], sortArr[i]);
                    }
                }
                
            }

            return sortArr;
        }

        static void ShowArray(int[] array, bool isSort = false )
        {
            if (isSort == true)
            {
                var sortedArray = SortArray(array);

                array = sortedArray;
            }            
            
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }

        static void Main()
        {
            ShowArray(GetArrayFromConsole(), false);            
        }
    }
}
