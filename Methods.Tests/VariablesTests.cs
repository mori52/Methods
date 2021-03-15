using NUnit.Framework;

namespace Methods.Tests
{
    public class VariablesTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(4, 6, 38)]
        [TestCase(-11, 7, -0.33)]
        public void Test1(int a, int b, double expected)
        {
            int actual = Variables.Task1(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, new int[] {2, 1})]
        [TestCase(4, 6, new int[] { 6, 4 })]
        [TestCase(-11, 7, new int[] { 7, -11 })]
        public void Test2(int a, int b, int[] expected)
        {
            int actual = Variables.Task2(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 2, new int[] { 2, 0 })]
        [TestCase(13, 6, new int[] { 2, 1 })]
        [TestCase(-11, 7, new int[] { -1, -4 })]
        public void Test3(int a, int b, int[] expected)
        {
            int actual = Variables.Task3(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 12, 65, 13)]
        [TestCase(1, 23, 54, 31)]
        [TestCase(3, 27, 36, 3)]
        public void Test4(int a, int b, int c, int expected)
        {
            int actual = Variables.Task4(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 6, 2, 5, "y=1x-3")]
        [TestCase(4, 1, 6, 2, "y=0x-2")]
        [TestCase(87, 36, 65, 7, "y=1x--58")]
        public void Test5(int x1, int y1, int x2, int y2, string expected)
        {
            int actual = Variables.Task5(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }









        //NegativeTests

        [TestCase(10, 0)]
        [TestCase(83, 0)]
        [TestCase(13892, 0)]
        public void Test3Exeption(int a, int b)
        {
            try
            {
                Variables.Task3(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(0, 76, 87)]
        [TestCase(0, 7, 759)]
        [TestCase(0, 431, 4)]
        public void Test3Exeption(int a, int b, int c)
        {
            try
            {
                Variables.Task4(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}