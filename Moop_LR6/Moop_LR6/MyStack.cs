using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Moop_LR6
{
    public class MyStack<T> : IMyStack<T>, IEnumerable<T>, ICloneable
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

        public object Clone()
        {
            //глубокое копирование стека
            MyStack<T> new_stack = new MyStack<T>(); //новый стек
            foreach (T t in stack)
            {
                new_stack.Push(t); //копирование каждого элемента
            }
            return new_stack;
        }
        public object MemberwiseClone()
        {
            //поверхностное копирование стека
            return (MyStack<T>)this.MemberwiseClone();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in stack)
            {
                yield return t; //возвращение каждого элемента стека по необходимости
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public static bool GetStackWithCondition(MyStack<int> stack)
        {
            //условие: сумма элементов больше 0
            int sum = 0;
            foreach (int i in stack)
            {
                sum += i; //сумма всех элементов стека
            }
            if (sum > 0) return true;
            return false;
        }
        public static bool GetStackWithConditionPipeLine(MyStack<int> stack)
        {
            int sum = stack.Aggregate(0, (product, next) => product + next); //сумма всех элементов стека
            if (sum > 0) return true;
            return false;
        }
    }
}
