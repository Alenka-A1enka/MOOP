using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Moop_LR5;
using NUnit.Framework;

namespace MyStack_Test
{
    [TestFixture]
    public class Stack_Test
    {
        [Test()]
        public void IEnumerable_Test()
        {
            string expected = "0123";

            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(0);

            string current_stack = "";
            foreach(int i in stack)
            {
                current_stack += i;
            }
            
            Assert.AreEqual(expected, current_stack);
        }
        [Test()]
        public void Clone()
        {
            string expected = "123";
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(0);

            MyStack<int> new_stack = new MyStack<int>();
            new_stack = (MyStack<int>)stack.Clone();

            stack.Pop();

            string current_stack = "";
            foreach (int i in stack)
            {
                current_stack += i;
            }

            Assert.AreEqual(expected, current_stack);
        }
    }
}