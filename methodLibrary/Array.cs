using System;
using System.Collections.Generic;

namespace Methods
{
    public class Array
    {
        public static void Main()
        {

        }

        public static int Task1(int[] array)
        {
            
            int min = 200;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int Task2(int[] array)
        {
          
            int max = -200;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int Task3(int[] array)
        {
            int min = 200;
            int minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int Task4(int[] array)
        {
            int max = -200;
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int Task5(int[] array)
        {
            int sum = 0;

            for (int i = 0; i <= array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int[] Task6(int[] array)
        {
            List<int> termsList = new List<int>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                termsList.Add(array[i]);
            }

            int[] terms = termsList.ToArray();

            return terms;
        }

        public static int Task7(int[] array)
        {
            int kolichestvo = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    kolichestvo++;
                }
            }
            return kolichestvo;
        }

        public static int[] Task9(int[] array)
        {
            // Метод прямого выбора

            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexOfMin = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[indexOfMin] < array[j])
                    {
                        indexOfMin = j;
                    }
                }

                int tmp = array[i];
                array[i] = array[indexOfMin];
                array[indexOfMin] = tmp;
            }

            List<int> termsList = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                termsList.Add(array[i]);
            }

            int[] terms = termsList.ToArray();

            return terms;
        }

        public static int[] Task10(int[] array)
        {
            // Метод прямого выбора

            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexOfMax = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[indexOfMax] < array[j])
                    {
                        indexOfMax = j;
                    }
                }

                int tmp = array[i];
                array[i] = array[indexOfMax];
                array[indexOfMax] = tmp;
            }

            List<int> termsList = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                termsList.Add(array[i]);
            }

            int[] terms = termsList.ToArray();

            return terms;
        }
    }
}
