using System;
namespace Methods
{
    public class Cycles
    {
        public static void Task1()
        {
            Console.WriteLine("Возвести число A в степень B:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int a1 = a;

            for (int i = 1; i < b; i++)
            {
                a *= a1;
            }
            Console.WriteLine(a);
        }

        public static void Task2()
        {
            Console.WriteLine("Вывести все числа от 1 до 1000, которые делятся на A");

            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Найдите количество положительных целых чисел, квадрат которых меньше A.");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    b++;
                }
            }
            Console.WriteLine(b);
        }

        public static void Task4()
        {
            Console.WriteLine("Вывести наибольший делитель (кроме самого A) числа A");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    b = i;
                }
            }
            Console.WriteLine(b);
        }

        public static void Task5()
        {
            Console.WriteLine("Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static void Task6()
        {
            Console.WriteLine("Выведите N-ое число ряда фибоначчи");

            int N = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            int tmp;

            for (int i = 1; i < N; i++)
            {
                tmp = a;
                a = b;
                b += tmp;

            }
            Console.WriteLine(a);
        }

        public static void Task7()
        {
            Console.WriteLine("Найти наибольший общий делитель двух чисел используя алгоритм Евклида");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine(a / b);
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
                Console.WriteLine(a + b);
            }
        }

        public static void Task8()
        {
            Console.WriteLine("Найдите число N методом половинного деления");

            int y = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine(middle);
        }

        public static void Task9()
        {
            Console.WriteLine("Найти количество нечетных цифр числа");

            int a = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine(kolichestvo);
        }

        public static void Task10()
        {
            Console.WriteLine("Найти число, которое является зеркальным отображением последовательности цифр заданного числа");

            int a = Convert.ToInt32(Console.ReadLine());
            int last;

            while (true)
            {
                if (a == 0)
                    break;
                last = a % 10;
                a = a / 10;
                Console.Write(last);
            }
        }

        public static void Task11()
        {
        }

        public static void Task12()
        {
        }
    }
}
