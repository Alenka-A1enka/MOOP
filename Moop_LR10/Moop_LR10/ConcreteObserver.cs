using System;

namespace Moop_LR10
{
    public delegate void Observer(Parameter parametr);
    public class ConcreteObserver
    {
        public static void ConcreteObserverCountActivations(Parameter parameter)
        {
            string str = "Количество активаций субъекта: " + parameter.count_of_activations;
            Total_Results.results.Add(str);
        }
        public static void ConcreteObserverJournalStates(Parameter parameter)
        {
            string str = "Журнал состояний: \nСостояние - Количество нахождений в состоянии \n";
            for (int i = 0; i < parameter.all_states.Length; i++)
            {
                str += parameter.all_states[i] + " - ";
                int kol = 0;
                foreach (int j in parameter.journal_of_states)
                {
                    if (j == i) kol++;
                }
                str += kol + "\n";
            }
            Total_Results.results.Add(str);
        }
    }
}
