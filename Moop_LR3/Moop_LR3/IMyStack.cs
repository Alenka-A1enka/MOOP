using System;

namespace Moop_LR3
{
    interface IMyStack
    {
        void Push(int item); //добавление нового элемента в стек
        int Pop(); //удаление и возвращение верхнего элемента
        int Peek(); //возвращение верхнего элемента без его удаления

        void Clear(); //очищение стека

        bool IsEmpety(); //проверка на наличие элементов
    }
}
