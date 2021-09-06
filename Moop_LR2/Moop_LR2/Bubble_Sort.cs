using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR2
{
    public class Bubble_Sort
    {
        public static int[] Sort(int[] array)
        {
            if (array == null)
                throw new ArgumentException("Массив пуст");


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    //сравниваем соседние элементы
                    if (array[j] > array[j + 1])
                    {
                        //если это необходимо меняем их местами
                        int t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }
            }
            return array;
        }
    }
}
