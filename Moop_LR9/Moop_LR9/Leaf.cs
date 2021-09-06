using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR9
{
    public class Leaf : Component
    {
        public Leaf(string name, int size = 0)
            : base(name, size)
        {

        }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override int Total_Size()
        {
            return Size;
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
