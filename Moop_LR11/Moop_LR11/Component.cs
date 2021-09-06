using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR11
{
    public abstract class Component
    {
        public string data = "";
        public static string length_check = "             ";
        public Component()
        {
            data = "Товар 1\nКол. 1" + length_check + "*50.0\n";
            data += "Товар 2\nКол. 2" + length_check + "*90.0\n";
            data += "Товар 3\nКол. 5" + length_check + "*10.0\n";
            data += "Товар 4\nКол. 3" + length_check + "*30.0\n";
            data += "Товар 5\nКол. 1" + length_check + "*60.0";
        }
        abstract public string ReturnText(List<int> Checked);
    }
}
