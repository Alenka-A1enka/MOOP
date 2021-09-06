using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Moop_LR2;
using NUnit.Framework;

namespace BubbleSort_Test
{
    [TestFixture]
    public class BubbleSort_Test
    {
        [Test()]
        public static void OnlyOneElementArray_Test()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            array = Bubble_Sort.Sort(array);
            Assert.AreEqual(expected, array);
        }
        [Test()]
        public static void ManyElementsArray_Test()
        {
            int[] array = { 5, 4, 3, 9, 8, 7 };
            int[] expected = { 3, 4, 5, 7, 8, 9 };
            array = Bubble_Sort.Sort(array);
            Assert.AreEqual(expected, array);
        }
        [Test()]
        public static void WithRepeatElementsArray_Test()
        {
            int[] array = { 5, 4, 3, 5, 4, 3 };
            int[] expected = { 3, 3, 4, 4, 5, 5 };
            array = Bubble_Sort.Sort(array);
            Assert.AreEqual(expected, array);
        }
        [Test()]
        public static void SameElementsArray_Test()
        {
            int[] array = { 4, 4, 4, 4 };
            int[] expected = { 4, 4, 4, 4 };
            array = Bubble_Sort.Sort(array);
            Assert.AreEqual(expected, array);
        }
        [Test()]
        public static void BackOrderArray_Test()
        {
            int[] array = { 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            array = Bubble_Sort.Sort(array);
            Assert.AreEqual(expected, array);
        }
        [Test()]
        public static void EmpetyArray_Test()
        {
            int[] array = { };
            int[] expected = { };
            array = Bubble_Sort.Sort(array);
            Assert.AreEqual(expected, array);
        }
    }
}