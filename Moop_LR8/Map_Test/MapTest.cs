using NUnit.Framework;
using Moop_LR8;

namespace Map_Test
{
    [TestFixture]
    public class MapTest
    {
        [Test()]
        public static void TestMap1()
        {
            double[] expected = { 1.0,4.0, 9.0 };
            double[] arr = new double[] { 1.0, 2.0, 3.0 };

            MapDelegate map = new MapDelegate(Program.mapFunc1);
            MainFunctions.Map(map, ref arr);
            Assert.AreEqual(expected, arr);
        }
        [Test()]
        public static void TestMap2()
        {
            double[] expected = { 1.0, 2.0, 6.0 };
            double[] arr = new double[] { 1.0, 2.0, 3.0 };

            MapDelegate map = new MapDelegate(Program.mapFunc2);
            MainFunctions.Map(map, ref arr);
            Assert.AreEqual(expected, arr);
        }
        [Test()]
        public static void TestMap3()
        {
            double[] expected = { 0.54, 0.88, 0.97 };
            double[] arr = new double[] { 1.0, 0.5, 0.25 };

            MapDelegate map = new MapDelegate(Program.mapFunc3);
            MainFunctions.Map(map, ref arr);
            Assert.AreEqual(expected, arr);
        }
    }
}