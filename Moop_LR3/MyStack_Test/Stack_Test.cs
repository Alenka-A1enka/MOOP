using Moop_LR3;
using NUnit.Framework;

namespace MyStack_Test
{
    [TestFixture]
    public class Stack_Test
    {
        [Test()]
        public void Create_Test()
        {
            MyStack stack = new MyStack();
            Assert.IsTrue(stack.IsEmpety()); //стек пустой после его создания
        }
        [Test()]
        public void Push_Test()
        {
            int expected = 1;
            MyStack stack = new MyStack();
            stack.Push(1);

            Assert.AreEqual(expected, stack.Peek());
        }
        [Test()]
        public void Pop_Test()
        {
            int expected = 2;
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop(); //удаление первого верхнего элемента
            Assert.AreEqual(expected, stack.Pop()); //следующий верхний элемент равен 2
        }
        [Test()]
        public void Peek_Test()
        {
            int expected = 3;
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(expected, stack.Peek());//чтение верхнего элемента, без его удаления
        }

        [Test()]
        public void Clear_Test()
        {
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2); 
            stack.Push(3);

            stack.Clear(); //очищение
            Assert.IsTrue(stack.IsEmpety()); //длина стека равна 0
        }
    }
}