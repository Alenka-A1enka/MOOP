using System;

namespace Moop_LR3
{
    public class MyStack : IMyStack
    {
        int[] stack;
        public MyStack()
        {
            stack = new int[0]; 
        }

        public void Clear()
        {
            int[] new_stack = new int[0];
            stack = new_stack;
        }

        public bool IsEmpety()
        {
            return stack.Length == 0;
        }

        public int Peek()
        {
            return stack[0]; //возвращение верхнего элемента без его удаления
        }

        public int Pop()
        {
            int pop_element = stack[0]; //верхний элемент стека

            int[] new_stack = new int[stack.Length - 1]; //новый стек
            for (int i = 0; i < new_stack.Length; i++)
                new_stack[i] = stack[i + 1]; //сдвигаем все элементы стека влево

            stack = new_stack;
            return pop_element;
        }

        public void Push(int item)
        {
            int[] new_stack = new int[stack.Length + 1]; //новый стек

            for (int i = 1; i < stack.Length + 1; i++)
                new_stack[i] = stack[i - 1]; //сдвиг элементов стека вправо

            new_stack[0] = item; //добавление верхнего элемента
            stack = new_stack;
        }
    }
}
