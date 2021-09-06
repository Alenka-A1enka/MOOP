using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR11
{
    public class ConcreteComponent : Component
    {
        public ConcreteComponent() : base()
        { }

        //выводит данных чека
        public override string ReturnText(List<int> Checked)
        {
            return data;
        }
    }
}
