using NUnit.Framework;
using System;
using System.Collections.Generic;
using Moop_LR10;

namespace Observer_Test
{
    [TestFixture]
    public class ObserverTest
    {
        [Test()]
        public void CountActivations_Test()
        {
            string expected = "Количество активаций субъекта: " + 4;
            Total_Results.results.Clear();

            Observable observable = new ConcreteObservable();
            observable.Observers += ConcreteObserver.ConcreteObserverCountActivations;

            Parameter p = new Parameter(4,
                new string[] {});
            observable.Notify(p);
            Assert.AreEqual(expected, Total_Results.results[0]);
        }
        [Test()]
        public void JournalStates_Test()
        {
            string expected = "Журнал состояний: \nСостояние - Количество нахождений в состоянии \n" +
                "Состояние 1 - 2\nСостояние 2 - 2\nСостояние 3 - 2\n";
            Total_Results.results.Clear();

            Observable observable = new ConcreteObservable();
            observable.Observers += ConcreteObserver.ConcreteObserverJournalStates;

            string[] states = { "Состояние 1", "Состояние 2", "Состояние 3" };
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(0);
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(2);

            Parameter p = new Parameter(1, states, list);
            observable.Notify(p);

            Console.WriteLine();
            foreach (string str in Total_Results.results)
            {
                Console.WriteLine(str);
            }
            Assert.AreEqual(expected, Total_Results.results[0]);
        }
    }
}