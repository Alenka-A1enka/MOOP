using Moop_LR9;
using NUnit.Framework;

namespace Composite_Test
{
    [TestFixture]
    public class CompositeTest
    {
        [Test()]
        public void AddElement_Test()
        {
            int expected = 35;
            Composite catalog = new Composite("Каталог 1");

            Composite catalog_2 = new Composite("Каталог 2");
            Composite file1 = new Composite("Файл 1", 10);
            catalog.Add(catalog_2);
            catalog_2.Add(new Leaf("Файл 2", 15));
            catalog_2.Add(new Leaf("Файл 3", 10));

            catalog.Add(file1);

            int total_size = catalog.Total_Size();
            Assert.AreEqual(expected, total_size);
        }
        [Test()]
        public void RemoveElement_Test()
        {
            int expected = 25;
            Composite catalog = new Composite("Каталог 1");
            Composite catalog_2 = new Composite("Каталог 2");
            Composite file1 = new Composite("Файл 1", 10);
            catalog.Add(catalog_2);
            catalog_2.Add(new Leaf("Файл 2", 15));
            catalog_2.Add(new Leaf("Файл 3", 10));

            catalog.Add(file1);

            catalog.Remove(file1); //удаление одного из файлов

            int total_size = catalog.Total_Size();
            Assert.AreEqual(expected, total_size);
        }
        [Test()]
        public void RemoveAll_Test()
        {
            int expected = 0;
            Composite catalog = new Composite("Каталог 1");
            Composite catalog_2 = new Composite("Каталог 2");
            Composite file1 = new Composite("Файл 1", 10);
            catalog.Add(catalog_2);
            catalog_2.Add(new Leaf("Файл 2", 15));
            catalog_2.Add(new Leaf("Файл 3", 10));

            catalog.Add(file1);

            catalog.Remove(catalog_2);
            catalog.Remove(file1);

            int total_size = catalog.Total_Size();
            Assert.AreEqual(expected, total_size);
        }

    }
}