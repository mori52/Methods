using System;
namespace Methods
{
    public class Branching_structures
    {
        private static void Task1()
        {
            Console.WriteLine("Выведите в консоль ответ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + b);
            }
            else if (a == b)
            {
                Console.WriteLine(a * b);
            }
            else if (a < b)
            {
                Console.WriteLine(a - b);
            }
        }

        private static void Task2()
        {
            Console.WriteLine("Определить какой четверти принадлежит точка с координатами (X,Y):");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
                if (y > 0)
                {
                    Console.WriteLine("Первая четверть");
                }
                else
                {
                    Console.WriteLine("Четвертая четверть");
                }
            else if (x < 0)
                if (y > 0)
                {
                    Console.WriteLine("Вторая четверть");
                }
                else
                {
                    Console.WriteLine("Третья четверть");
                }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Не принадлежит ни одной четверти");
            }
        }

        private static void Task3()
        {
            Console.WriteLine("Выведите в консоль числа в порядке возрастания");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                if (b > c)
                {
                    Console.WriteLine($"{c}, {b}, {a}");
                }
                else
                {
                    Console.WriteLine($"{b}, {c}, {a}");
                }
            else if (b > a && b > c)
                if (a > c)
                {
                    Console.WriteLine($"{c}, {a}, {b}");
                }
                else
                {
                    Console.WriteLine($"{a}, {c}, {b}");
                }
            else if (c > a && c > b)
                if (a > b)
                {
                    Console.WriteLine($"{b}, {a}, {c}");
                }
                else
                {
                    Console.WriteLine($"{a}, {b}, {c}");
                }
            else if (a == b && b == c && a == c)
            {
                Console.WriteLine($"{c}, {b}, {a}");
            }
        }

        private static void Task4()
        {
            Console.WriteLine("Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int D = b * b - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (D == 0)
            {
                int x = -b / (2 * a);
                Console.WriteLine($"У уравнения один корень - {x}");
            }
            else if (D > 0)
            {
                double x1 = (-b + Math.Pow(D, 0.5d)) / (2 * a);
                double x2 = (-b - Math.Pow(D, 0.5d)) / (2 * a);
                Console.WriteLine($"У уравнения два корня: {x1}, {x2}");
            }
        }

        private static void Task5()
        {
            Console.WriteLine("Выведите в консоль прописную запись этого числа");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 10;
            int c = a % 10;

            if (b == 1)
            {
                switch (c)
                {
                    case 1:
                        Console.WriteLine("одиннадцать");
                        break;
                    case 2:
                        Console.WriteLine("двенадцать");
                        break;
                    case 3:
                        Console.WriteLine("тринадцать");
                        break;
                    case 4:
                        Console.WriteLine("четырнадцать");
                        break;
                    case 5:
                        Console.WriteLine("пятнадцать");
                        break;
                    case 6:
                        Console.WriteLine("шестнадцать");
                        break;
                    case 7:
                        Console.WriteLine("семьнадцать");
                        break;
                    case 8:
                        Console.WriteLine("восемьнадцать");
                        break;
                    case 9:
                        Console.WriteLine("девятнадцать");
                        break;
                    case 0:
                        Console.WriteLine("десять");
                        break;
                }
            }

            if (b == 2)
                Console.Write("двадцать ");
            else if (b == 3)
                Console.Write("тридцать ");
            else if (b == 4)
                Console.Write("сорок ");
            else if (b == 5)
                Console.Write("пятьдесят ");
            else if (b == 6)
                Console.Write("шестьдесят ");
            else if (b == 7)
                Console.Write("семьдесят ");
            else if (b == 8)
                Console.Write("восемьдесят ");
            else if (b == 9)
                Console.Write("девяносто ");

            switch (c)
            {
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
                case 9:
                    Console.WriteLine("девять");
                    break;
                case 0:
                    break;
            }
        }
    }
}
