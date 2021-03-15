using System;
using System.Collections.Generic;

namespace Methods
{
    public class Cycles
    {
        public static void Main()
        {
        }

        public static int Task1(int a, int b)
        {
            Console.WriteLine("Возвести число A в степень B:");

            int a1 = a;

            for (int i = 1; i < b; i++)
            {
                a *= a1;
            }
            return a;
        }

        public static int[] Task2(int a)
        {
            Console.WriteLine("Вывести все числа от 1 до 1000, которые делятся на A");

            List<int> termsList = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    termsList.Add(i);
                }    
            }

            int[] terms = termsList.ToArray();

            return terms;
        }

        public static int Task3(int a)
        {
            Console.WriteLine("Найдите количество положительных целых чисел, квадрат которых меньше A.");

            int b = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    b++;
                }
            }
            return b;
        }

        public static int Task4(int a)
        {
            Console.WriteLine("Вывести наибольший делитель (кроме самого A) числа A");

            int b = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    b = i;
                }
            }
            return b;
        }

        public static int Task5( int a, int b)
        {
            Console.WriteLine("Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7");

            int x = 0;

            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                         x += i;
                    }
                }
                return x;   
            }

            else if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                         x += i;
                    }
                }
                return x;
            }

            else
                throw new Exception("a==b");
        }

        public static int Task6(int N)
        {
            Console.WriteLine("Выведите N-ое число ряда фибоначчи");

            int a = 1;
            int b = 1;
            int tmp;

            for (int i = 1; i < N; i++)
            {
                tmp = a;
                a = b;
                b += tmp;

            }
            return a;
        }

        public static int Task7(int a, int b)
        {
            Console.WriteLine("Найти наибольший общий делитель двух чисел используя алгоритм Евклида");

            if (a % b == 0)
            {
                return a / b;
            }
            else
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }
                return a + b;
            }
        }

        public static int Task8(int y)
        {
            Console.WriteLine("Найдите число N методом половинного деления");

            double left = 0;
            double right = y;
            double middle = right;

            while (y != middle * middle * middle)
            {
                if (middle * middle * middle > y)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }

                middle = (left + right) / 2;
            }
            return (int)middle;
        }

        public static int Task9(int a)
        {
            Console.WriteLine("Найти количество нечетных цифр числа");

            int tsifra;
            int kolichestvo = 0;

            while (true)
            {
                if (a == 0)
                    break;
                tsifra = a % 10;
                a = a / 10;

                if (tsifra % 2 != 0)
                {
                    kolichestvo++;
                }
            }
            return kolichestvo;
        }

        public static int Task10(int a)
        {
            Console.WriteLine("Найти число, которое является зеркальным отображением последовательности цифр заданного числа");

            int last;

            while (true)
            {
                if (a == 0)
                    throw new Exception("a==0");
                last = a % 10;
                a = a / 10;
                return last;
            }
        }
    }
}
