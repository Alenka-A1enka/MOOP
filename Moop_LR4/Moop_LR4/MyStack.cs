using System;

namespace Moop_LR4
{
    public class MyStack<T> : IMyStack<T>
    {
        T[] stack;
        public MyStack()
        {
            stack = new T[0];
        }

        public void Clear()
        {
            T[] new_stack = new T[0];
            stack = new_stack;
        }

        public bool IsEmpety()
        {
            return stack.Length == 0;
        }

        public T Peek()
        {
            return stack[0]; //возвращение верхнего элемента без его удаления
        }

        public T Pop()
        {
            T pop_element = stack[0]; //верхний элемент стека

            T[] new_stack = new T[stack.Length - 1]; //новый стек
            for (int i = 0; i < new_stack.Length; i++)
                new_stack[i] = stack[i + 1]; //сдвигаем все элементы стека влево

            stack = new_stack;
            return pop_element;
        }

        public void Push(T item)
        {
            T[] new_stack = new T[stack.Length + 1]; //новый стек

            for (int i = 1; i < stack.Length + 1; i++)
                new_stack[i] = stack[i - 1]; //сдвиг элементов стека вправо

            new_stack[0] = item; //добавление верхнего элемента
            stack = new_stack;
        }
    }
}
