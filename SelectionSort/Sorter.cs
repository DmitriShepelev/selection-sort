using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[] array)
        {
            // #1. Implement the method using a loop statements.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int tmp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = tmp;
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[] array)
        {
            // #2. Implement the method using recursion algorithm.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            RecursiveSelectionSort(array, 0, array.Length);

            static void RecursiveSelectionSort(int[] array, int i, int lenght)
            {
                if (i == lenght)
                {
                    return;
                }

                int minIndex = MinIndex(i, lenght - 1, array);

                if (minIndex != i)
                {
                    int tmp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = tmp;
                }

                RecursiveSelectionSort(array, i + 1, lenght);
            }

            static int MinIndex(int i, int length, int[] arr)
            {
                if (i == length)
                {
                    return i;
                }

                int minIndex = MinIndex(i + 1, length, arr);

                return (arr[i] < arr[minIndex]) ? i : minIndex;
            }
        }
    }
}
