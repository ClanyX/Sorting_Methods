using System;

namespace Sorting
{
    class Program
    {
        //Quick Sort
        static void QuickSort(int[] input, int leftIndex, int rightIndex) {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = input[leftIndex];
            while (i <= j)
            {
                while (input[i] < pivot)
                    i++;

                while (input[j] > pivot)
                    j--;
                if (i <= j)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j--;
                }
            }
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
        public static void Main(string[] args
            ///*QuickSort method only*/, int leftIndex, int rightIndex
            )
        {
            //input list of number
            int[] input = { 4, 6, 16, 9, 7, 5, 1 };


            //sorting methods in comment

            //QuickSort(input, leftIndex, rightIndex);
            //SelectionSort(input);
            //InsertionSort(input);
            //BubbleSort(input);

            foreach (int value in input)
                Console.Write(value + " ");
        }
    }
}