using System;

namespace Moop_LR8
{
    public class MainFunctions
    {
        //метод прямоугольников 
        internal static double Rectangle(MyDelegate func, double a, double b, int n)
        {
            double result = 0;
            double h = (double)(b - a) / n; //длина шага
            double x1 = a; 
            for (int k = 0; k < n; k++)
            {
                double x2 = (double)(x1 + h);
                result = func((x2 + x1) / 2.0);

                x1 += (double)h; //приращение аргумента
            }
            result *= h;

            return result;
        }
        public static void Map(MapDelegate map, ref double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = map(array[i]);
            }
        }
    }
}
