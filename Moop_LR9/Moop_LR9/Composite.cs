using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR9
{
    public class Composite : Component
    {
        List<Component> all_files; //список всех файлов и подкаталогов
        public Composite(string name, int size = 0)
            : base(name, size)
        {
            all_files = new List<Component>();
        }
        public override void Add(Component c)
        {
            all_files.Add(c);
        }

        public override int Total_Size()
        {
            int current_size = Size; //размер текущего файла или каталога

            foreach (Component c in all_files)
            {
                current_size += c.Total_Size(); //перебор размеров всех файлов в каталоге
            }
            return current_size;
        }

        public override void Remove(Component c)
        {
            all_files.Remove(c);
        }
    }
}
