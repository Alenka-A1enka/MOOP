using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moop_LR9
{
    public abstract class Component
    {
        public string Name { get; set; } //имя каталога или файла
        public int Size { get; set; } // размер файла указывается при его создании
        public Component(string name, int size = 0)
        {
            Name = name;
            Size = size;
        }
        public abstract void Add(Component c); //добавление каталога или файла
        public abstract void Remove(Component c); //удаление каталога или файла
        public abstract int Total_Size(); //вывод суммарного размера каталога 
    }
}
