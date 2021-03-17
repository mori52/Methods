using NUnit.Framework;

namespace Methods.Tests
{
    public class ArrayTests
    {
        [TestCase(new int[] { 2, 9, 34, 1, 24 }, 1)]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, 0)]
        [TestCase(new int[] { -4, -10, 30 }, -4)]
        public void Test1(int[] array , int expected)
        {
            int actual = Array.Task1(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, 34)]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, 1)]
        [TestCase(new int[] { -4, -10, 30 }, 30)]
        public void Test2(int[] array, int expected)
        {
            int actual = Array.Task2(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, 3)]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, 3)]
        [TestCase(new int[] { -4, -10, 30 }, 0)]
        public void Test3(int[] array, int expected)
        {
            int actual = Array.Task3(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, 2)]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, 4)]
        [TestCase(new int[] { -4, -10, 30 }, 2)]
        public void Test4(int[] array, int expected)
        {
            int actual = Array.Task4(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, 10)]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, 0)]
        [TestCase(new int[] { -4, -10, 30 }, -10)]
        public void Test5(int[] array, int expected)
        {
            int actual = Array.Task5(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, new int[] { 24, 1, 34, 9, 2 })]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 0 })]
        [TestCase(new int[] { -4, -10, 30 }, new int[] { 30, -10, -4 })]
        public void Test6(int[] array, int[] expected)
        {
            int[] actual = Array.Task6(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, 2)]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, 2)]
        [TestCase(new int[] { -4, -10, 30 }, 1)]
        public void Test7(int[] array, int expected)
        {
            int actual = Array.Task7(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, new int[] { 1,2,9, 24, 34 })]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, new int[] { 0, 0, 0, 0, 1 })]
        [TestCase(new int[] { -4, -10, 30 }, new int[] { -4, -10, 30 })]
        public void Test9(int[] array, int[] expected)
        {
            int[] actual = Array.Task9(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 34, 1, 24 }, new int[] { 34, 24, 9, 2, 1 })]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 0 })]
        [TestCase(new int[] { -4, -10, 30 }, new int[] { 30, -10, -4 })]
        public void Test10(int[] array, int[] expected)
        {
            int[] actual = Array.Task10(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
