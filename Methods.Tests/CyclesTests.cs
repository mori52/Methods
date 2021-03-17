using NUnit.Framework;
namespace Methods.Tests
{
    public class CyclesTests
    {
        [TestCase(2, 5, 32)]
        [TestCase(6, 3, 216)]
        [TestCase(3, 4, 81)]
        public void Test1(int a, int b, int expected)
        {
            int actual = Cycles.Task1(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { })]
        [TestCase(6, new int[] { })]
        [TestCase(3, new int[] { })]
        public void Test2(int a, int[] expected)
        {
            var actual = Cycles.Task2(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(6, 2)]
        [TestCase(76, 8)]
        public void Test3(int a, int expected)
        {
            int actual = Cycles.Task3(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 3)]
        [TestCase(87, 29)]
        [TestCase(43, 1)]
        public void Test4(int a, int expected)
        {
            int actual = Cycles.Task4(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 3, 7)]
        [TestCase(22, 15, 21)]
        [TestCase(43, 1, 147)]
        public void Test5(int a, int b, int expected)
        {
            int actual = Cycles.Task5(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(34, 5702887)]
        [TestCase(3, 2)]
        [TestCase(14, 377)]
        public void Test6(int N, int expected)
        {
            int actual = Cycles.Task6(N);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 1)]
        [TestCase(4, 16, 4)]
        [TestCase(9, 27, 9)]
        public void Test7(int a, int b, int expected)
        {
            int actual = Cycles.Task7(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(64, 4)]
        public void Test8(int y, int expected)
        {
            int actual = Cycles.Task8(y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 1)]
        [TestCase(457, 2)]
        [TestCase(45555, 4)]
        public void Test9(int a, int expected)
        {
            int actual = Cycles.Task9(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 72)]
        [TestCase(8754, 4578)]
        [TestCase(64109, 90146)]
        public void Test10(int y, int expected)
        {
            int actual = Cycles.Task10(y);

            Assert.AreEqual(expected, actual);
        }





        //NegativeTests

        [TestCase(0)]
        public void Test10Exeption(int a)
        {
            try
            {
                Cycles.Task10(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
