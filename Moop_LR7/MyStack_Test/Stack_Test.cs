using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Moop_LR7;
using NUnit.Framework;

namespace MyStack_Test
{
    [TestFixture]
    public class Stack_Test
    {
        [Test()]
        public void BinarySerialize_Test()
        {
            MyStack<int> expected = new MyStack<int>();
            expected.Push(1);
            expected.Push(2);
            expected.Push(3);

            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            MyStack<int>.Save_BinaryFormat(stack);
            MyStack<int> new_stack = MyStack<int>.Open_BinaryFormat();
            Assert.AreEqual(expected, new_stack);
        }
    }
}