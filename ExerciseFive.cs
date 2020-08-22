using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{1,4,3,2,6,5};


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }

            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join("-", arr));
        }
    }
}
