using System;
namespace Methods
{
    public class Variables
    {
        private static void Task1()
        {
            Console.WriteLine("Выведите в консоль решение (5*A+B^2)/(B-A)");

            Console.WriteLine("Введите первую переменную:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = (5 * a + b * b) / (b - a);
            Console.WriteLine($"Решение уравнения: {c}");
        }

        private static void Task2()
        {
            Console.WriteLine("Поменяйте содержимое переменных A и B местами:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void Task3()
        {
            Console.WriteLine("Выведите в консоль результат деления A на B и остаток от деления:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a / b;
            int d = a % b;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        private static void Task4()
        {
            Console.WriteLine("Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int x = (c - b) / a;
            Console.WriteLine(x);
        }

        private static void Task5()
        {
            Console.WriteLine("Выведите уравнение прямой в формате Y=AX+B:");

            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int k = (y1 - y2) / (x1 - x2);
            int b = y2 - k * x2;
            Console.WriteLine($"y={k}x-{b}");
        }
    }
}
