﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR7
{
    interface IMyStack<T>
    {
        void Push(T item); //добавление нового элемента в стек
        T Pop(); //удаление и возвращение верхнего элемента
        T Peek(); //возвращение верхнего элемента без его удаления

        void Clear(); //очищение стека

        bool IsEmpety(); //проверка на наличие элементов
    }
}
