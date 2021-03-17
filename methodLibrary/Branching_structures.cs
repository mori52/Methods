using System;
namespace Methods
{
    public class Branching_structures
    {
        public static void Main()
        {
        }


        private static int Task1(int a, int b)
        {
            Console.WriteLine("Выведите в консоль ответ");

            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
            
        }

        private static string Task2(int x, int y)
        {
            Console.WriteLine("Определить какой четверти принадлежит точка с координатами (X,Y):");

            if (x > 0)
                if (y > 0)
                {
                    string ch = "Первая четверть";
                    return ch;
                }
                else
                {
                    string ch = "Четвертая четверть";
                    return ch;
                }
            else if (x < 0)
                if (y > 0)
                {
                    string ch = "Вторая четверть";
                    return ch;
                }
                else
                {
                    string ch = "Третья четверть";
                    return ch;
                }
            else 
            {
                string ch = "Не принадлежит ни одной четверти";
                return ch;
            }
        }

        private static string Task3(int a, int b, int c)
        {
            Console.WriteLine("Выведите в консоль числа в порядке возрастания");

            if (a > b && a > c)
                if (b > c)
                {
                    string x = c +" "+b +" "+a;
                    return x;
                }
                else
                {
                    string x = b + " " + c + " " + a;
                    return x;
                }
            else if (b > a && b > c)
                if (a > c)
                {
                    string x = c + " " + a + " " + b;
                    return x;
                }
                else
                {
                    string x = a + " " + c + " " + b;
                    return x;
                }
            else if (c > a && c > b)
                if (a > b)
                {
                    string x = b + " " + a + " " + c;
                    return x;
                }
                else
                {
                    string x = a + " " + b + " " + c;
                    return x;
                }
            else
            {
                Console.WriteLine($"{c}, {b}, {a}");
                string x = c + " " + b + " " + a;
                return x;
            }
        }

        private static string Task4(int a, int b, int c)
        {
            Console.WriteLine("Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0");

            int D = b * b - 4 * a * c;

            if (D < 0)
            {
                throw new Exception("Корней нет");
                
            }
            else if (D == 0)
            {
                int x = -b / (2 * a);
                string y = "У уравнения один корень " + x;
                return y;
            }
            else
            {
                double x1 = (-b + Math.Pow(D, 0.5d)) / (2 * a);
                double x2 = (-b - Math.Pow(D, 0.5d)) / (2 * a);
                string y = "У уравнения два корня: " + x1 + ", " + x2;
                return y;
            }
        }

        private static string Task5(int a)
        {
            Console.WriteLine("Выведите в консоль прописную запись этого числа");

            int b = a / 10;
            int c = a % 10;

            if (b == 1)
            {
                switch (c)
                {
                    case 1:
                        return "одиннадцать";
                    case 2:
                        return "двенадцать";
                    case 3:
                        return "тринадцать";
                    case 4:
                        return "четырнадцать";
                    case 5:
                        return "пятнадцать";
                    case 6:
                        return "шестнадцать";
                    case 7:
                        return "семьнадцать";
                    case 8:
                        return "восемьнадцать";
                    case 9:
                        return "девятнадцать";
                    case 0:
                        return "десять";
                }
            }

            string x = "";

            if (b == 2)
                x = "двадцать ";
            else if (b == 3)
                x = "тридцать ";
            else if (b == 4)
                x = "сорок ";
            else if (b == 5)
                x = "пятьдесят ";
            else if (b == 6)
                x = "шестьдесят ";
            else if (b == 7)
                x = "семьдесят ";
            else if (b == 8)
                x = "восемьдесят ";
            else
                x = "девяносто ";

            switch (c)
            {
                case 1:
                    x += "один";
                    return x;
                case 2:
                    x += "два";
                    return x;
                case 3:
                    x += "три";
                    return x;
                case 4:
                    x += "четыре";
                    return x;
                case 5:
                    x += "пять";
                    return x;
                case 6:
                    x += "шесть";
                    return x;
                case 7:
                    x += "семь";
                    return x;
                case 8:
                    x += "восемь";
                    return x;
                case 9:
                    x += "девять";
                    return x;
                case 0:
                    return x;
            }
        }
    }
}
