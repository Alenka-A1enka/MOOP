using System;

namespace Moop_LR8
{
    delegate double MyDelegate(double x);
    public delegate double MapDelegate(double x);
    public delegate double FoldDelegate(double x, double y);
    public class Program
    {
        static void Main(string[] args)
        {
            MyDelegate functions = new MyDelegate(integralFunc1);
            Console.WriteLine("Введите шаг");
            int N = Convert.ToInt32(Console.ReadLine());


            //значение первого интеграла
            Console.Write("Значение интеграла с шагом {0}: ", N);
            double resN = MainFunctions.Rectangle(functions, 0.4, 1.0, N);
            Console.WriteLine(resN);
            Console.Write("Значение интеграла с шагом {0}: ", 2 * N);
            double res2N = MainFunctions.Rectangle(functions, 0.4, 1.0, 2 * N);
            Console.WriteLine(res2N);
            Console.Write("Погрешность по Рунге: ");
            Console.WriteLine((Math.Abs(res2N - resN) / 3.0) + "\n");


            //значение второго интеграла
            functions = integralFunc2;
            Console.Write("Значение интеграла с шагом {0}: ", N);
            resN = MainFunctions.Rectangle(functions, 0.0, Math.PI / 2, N);
            Console.WriteLine(resN);
            Console.Write("Значение интеграла с шагом {0}: ", 2 * N);
            res2N = MainFunctions.Rectangle(functions, 0.0, Math.PI / 2, 2 * N);
            Console.WriteLine(res2N);
            Console.Write("Погрешность по Рунге: ");
            Console.WriteLine((Math.Abs(res2N - resN) / 3.0) + "\n");


            //значение третьего интеграла
            functions = integralFunc3;
            Console.Write("Значение интеграла с шагом {0}: ", N);
            resN = MainFunctions.Rectangle(functions, 0.1, 1.0, N);
            Console.WriteLine(resN);
            Console.Write("Значение интеграла с шагом {0}: ", 2 * N);
            res2N = MainFunctions.Rectangle(functions, 0.1, 1.0, 2 * N);
            Console.WriteLine(res2N);
            Console.Write("Погрешность по Рунге: ");
            Console.WriteLine((Math.Abs(res2N - resN) / 3.0) + "\n");


            Console.ReadLine();
        } 
        
        //функции для отображения
        public static double mapFunc1(double x)
        {
            return x * x;
        }
        public static double mapFunc2(double x)
        {
            //факториал числа
            int factorial = 1;  
            for (int i = 2; i <= x; i++) 
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        public static double mapFunc3(double x)
        {
            return Math.Round(Math.Cos(x), 2);
        }

        //функции для свертки
        public static double foldFunc1(double x, double y)
        {
            return x + y;
        }
        public static double foldFunc2(double x, double y)
        {
            return Math.Min(x, y);
        }
        public static double foldFunc3(double x, double y)
        {
            return (x + y) / 2.0;
        }

        //функции для численного интегрирования
        public static double integralFunc1(double x)
        {
            double f = Math.Exp(-x * x + 0.38) / (2.0 + Math.Sin(1.0 / (1.5 + x * x)));

            return f;
        }
        public static double integralFunc2(double x)
        {
            double f = Math.Exp(-Math.Tan(0.84 * x)) / (0.35 + Math.Cos(x));

            return f;
        }
        public static double integralFunc3(double x)
        {
            double f = Math.Log(1 + x) / x;

            return f;
        }
    }
}
