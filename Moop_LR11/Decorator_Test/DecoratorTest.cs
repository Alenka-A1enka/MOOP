using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Moop_LR11;
using NUnit.Framework;

namespace Decorator_Test
{
    [TestFixture]
    public class DecoratorTest
    {
        [Test()]
        public void AllChecked_Test()
        {
            Component component = new Additions();
            string expected = "*Название фирмы*\n\n*Адрес*\n\n" + component.data + "\nИТОГ: " 
                + Component.length_check + "*500" + "\n\n*Рекламное объявление*";

            Assert.AreEqual(expected, component.ReturnText(new List<int>() { 1, 2, 3, 4 }));
        }
        [Test()]
        public void OnlyData_Test()
        {
            Component component = new ConcreteComponent();
            string expected = component.data;

            Assert.AreEqual(expected, component.ReturnText(new List<int>()));
        }
    }
}