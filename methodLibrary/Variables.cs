using System;
namespace Methods
{
    public class Variables
    {
        public static void Main()
        {
            
        }

        public static double Task1(int a, int b)
        {
            Console.WriteLine("Выведите в консоль решение (5*A+B^2)/(B-A)");
            return (5 * a + b * b) / (b - a);
        }

        private static int[] Task2(int a, int b)
        {
            Console.WriteLine("Поменяйте содержимое переменных A и B местами:");

            int tmp = a;
            a = b;
            b = tmp;
            int[] arr = new int[] { a, b };

            return arr;
        }

        private static int[] Task3( int a, int b)
        {
            Console.WriteLine("Выведите в консоль результат деления A на B и остаток от деления:");

            if (b==0)
            {
                throw new Exception("b==0");
            }

            int c = a / b;
            int d = a % b;
            int[] arr = new int[] { c, d };

            return arr;
        }

        private static int Task4(int a, int b, int c)
        {
            Console.WriteLine("Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C:");

            if (a == 0)
            {
                throw new Exception("a==0");
            }

            int x = (c - b) / a;

            return x;
        }

        private static string Task5(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Выведите уравнение прямой в формате Y=AX+B:");

            
            int a = (y1 - y2) / (x1 - x2);
            int b = y2 - a * x2;

            string x = "y="+a+"x-"+b;
            return x;
        }
    }
}
