using Moop_LR4;
using NUnit.Framework;

namespace MyStack_Test
{
    [TestFixture]
    public class Stack_Test
    {
        [Test()]
        public void Create_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            Assert.IsTrue(stack.IsEmpety()); //стек пустой после его создания
        }
        [Test()]
        public void Push_Test()
        {
            string expected = "1";
            MyStack<string> stack = new MyStack<string>();
            stack.Push("1");

            Assert.AreEqual(expected, stack.Peek());
        }
        [Test()]
        public void Pop_Test()
        {
            double expected = 2.1;
            MyStack<double> stack = new MyStack<double>();
            stack.Push(1.3);
            stack.Push(2.1);
            stack.Push(3);

            stack.Pop(); //удаление первого верхнего элемента
            Assert.AreEqual(expected, stack.Pop()); //следующий верхний элемент равен 2
        }
        [Test()]
        public void Peek_Test()
        {
            string expected = "3";
            MyStack<string> stack = new MyStack<string>();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");

            Assert.AreEqual(expected, stack.Peek());//чтение верхнего элемента, без его удаления
        }

        [Test()]
        public void Clear_Test()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Clear(); //очищение
            Assert.IsTrue(stack.IsEmpety()); //длина стека равна 0
        }
    }
}