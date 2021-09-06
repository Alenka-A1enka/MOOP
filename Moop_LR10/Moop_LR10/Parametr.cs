using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR10
{
    public class Parameter
    {
        public int count_of_activations; //количество активаций субъекта

        public string[] all_states; //все состояния субъекта
        public List<int> journal_of_states; //журнал состояний, в которых находился субъекта
        public Parameter(int count_of_activations, string[] all_states,
            List<int> journal_of_states = null)
        {
            this.count_of_activations = count_of_activations;
            this.all_states = all_states;
            this.journal_of_states = journal_of_states;
        }
    }
}
