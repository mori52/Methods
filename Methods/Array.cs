using System;
namespace Methods
{
    public class Arrils
    {
        public static void Task1()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int min = 200;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            Console.WriteLine(min);
        }

        public static void Task2()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int max = -200;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void Task3()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

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

            Console.WriteLine(minIndex);
        }

        public static void Task4()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

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
            Console.WriteLine(maxIndex);
        }

        public static void Task5()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int sum = 0;

            for (int i = 0; i <= array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }

        public static void Task6()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void Task7()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int kolichestvo = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    kolichestvo++;
                }
            }
            Console.WriteLine(kolichestvo);
        }

        public static void Task8()
        {
        }

        public static void Task9()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

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

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void Task10()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

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

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
