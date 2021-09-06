using Moop_LR6;
using NUnit.Framework;

namespace MyStack_Test
{
    [TestFixture]
    public class Stack_Test
    {
        [Test()]
        public void SumBiggerThenZero_ForCondition()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(-3);
            stack.Push(5);

            Assert.IsTrue(MyStack<int>.GetStackWithCondition(stack));
        }
        [Test()]
        public void SumSmallerThenZero_ForCondition()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(-10);
            stack.Push(5);

            Assert.IsFalse(MyStack<int>.GetStackWithCondition(stack));
        }


        [Test()]
        public void SumBiggerThenZero_ForConditionPipeline()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(-3);
            stack.Push(5);

            Assert.IsTrue(MyStack<int>.GetStackWithConditionPipeLine(stack));
        }
        [Test()]
        public void SumSmallerThenZero_ForConditionPipeline()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(-10);
            stack.Push(5);

            Assert.IsFalse(MyStack<int>.GetStackWithConditionPipeLine(stack));
        }
    }
}