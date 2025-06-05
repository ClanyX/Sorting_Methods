using System;

namespace Sorting
{
    class Program
    {
        static void PrintArr(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return;
            }
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
                Console.WriteLine();
            }
        }

        static int[]? Sort(int[] arr)
        {
            if(arr == null || arr.Length == 0) return null;

            Console.Write("Choose one of the algorithms\n1. QuickSort\n2. SelectSort\n3. InsertSort\n4. BubblesSort\n\nType the number: ");
            string? t = Console.ReadLine();
            if(string.IsNullOrEmpty(t))
            {
                Console.WriteLine("Choose one of the options!");
                return null;
            }

            int x;

            if(!int.TryParse(t, out x))
            {
                Console.WriteLine("Choose one of the options!");
                return null;
            }

            if (x < 1 || x > 4) return null;

            switch (x)
            {
                //Quick
                case 1:
                    Console.Clear();
                    QuickSort(arr, 0, arr.Length - 1);
                    break;

                //Selection
                case 2:
                    SelectionSort(arr);
                    break;

                //Insert
                case 3:
                    InsertionSort(arr);
                    break;

                //Bubble
                case 4:
                    BubbleSort(arr);
                    break;

                default:
                    break;
            }

            return arr;
        }

        //Quick Sort
        public static void QuickSort(int[] input, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int pivot = input[leftIndex + (rightIndex - leftIndex) / 2];

            int i = leftIndex;
            int j = rightIndex;

            while (i <= j)
            {
                while (input[i] < pivot) i++;

                while (input[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j--;
                }
            }
            if (leftIndex < j) QuickSort(input, leftIndex, j);
            if (i < rightIndex) QuickSort(input, i, rightIndex);
        }

        //Selection Sort
        static void SelectionSort(int[] input)
        {
            int n = input.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < n; j++)
                    if (input[j] < input[min_idx])
                        min_idx = j;
                 
                int temp = input[min_idx];
                input[min_idx] = input[i];
                input[i] = temp;
            }
        }

        //Inserting Sort
        static void InsertionSort(int[] input) 
        {
            int n = input.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = input[i];
                int j = i - 1;

                while (j >= 0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }
                input[j + 1] = key;
            }
        }

        //Bubble Sort
        static void BubbleSort(int[] input)
        {
            var itemMoved = false;

            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
        }

        //Output
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int[] input = new int[10];
                for (int i = 0; i < 10; ++i)
                {
                    input[i] = rnd.Next(1, 31);
                }

                var sortedArray = Sort(input);
                if(sortedArray != null) PrintArr(sortedArray);

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}