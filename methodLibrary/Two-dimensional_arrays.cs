using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    public class Two_dimensional_arrays
    {
        public static int Task1(int[,] array)
        {
            int min = 200;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j< array.Length; j++)
                {
                    if (min > array[i,j])
                    {
                        min = array[i,j];
                    }
                }
            }

            return min;
        }

        public static int Task2(int[,] array)
        {
            int max = -200;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        public static string Task3(int[,] array)
        {
            int min = 200;
            string minIndex = "";

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minIndex = Convert.ToString($"{i}, {j}");
                    }
                }
            }

            return minIndex;
        }

        public static string Task4(int[,] array)
        {
            int max = -200;
            string maxIndex = "";

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxIndex = Convert.ToString($"{i}, {j}");
                    }
                }
            }

            return maxIndex;
        }

        public static int Task5(int[,] array)
        {
            int counter = 0;

            for (int i = 0; i< array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if ((i<=0 || array[i,j]>array[i-1,j])
                        && (i >=array.GetLength(0)-1 || array[i,j] > array[i+1,j])
                        && (j<=0 || array[i,j] > array[i,j-1])
                        && (j>=array.GetLength(1)-1 || array[i,j]>array[i,j+1]))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
