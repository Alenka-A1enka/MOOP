using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR11
{
    public class Decorator : Component
    {
        public Decorator() : base()
        {
        }
        //вывод данных чека
        public override string ReturnText(List<int> Checked)
        {
            return data;
        }
    }
    public class Additions : Decorator
    {
        public Additions()
   : base()
        {
        }
        public override string ReturnText(List<int> Checked)
        {
            //добавление: названия фирмы, адреса, суммы, рекламного объявления
            string str = "";
            if (Checked.Contains(1))
            {
                str += "*Название фирмы*\n\n";
            }
            if (Checked.Contains(2))
            {
                str += "*Адрес*\n\n";
            }

            str += base.ReturnText(Checked);

            if (Checked.Contains(3))
            {
                str += "\nИТОГ: " + length_check + "*500";
            }
            if (Checked.Contains(4))
            {
                str += "\n\n*Рекламное объявление*";
            }

            return str;
        }
    }
}
