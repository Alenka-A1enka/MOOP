using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR10
{
    public class Observable
    {
        private event Observer observers;
        public event Observer Observers
        {
            add
            {
                observers += value;
            }
            remove
            {
                observers -= value;
            }
        }
        public void Notify(Parameter parameter)
        {
            if (observers != null)
                observers(parameter);
        }
    }
}
