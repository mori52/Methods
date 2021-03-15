using NUnit.Framework;

namespace Methods.Tests
{
    public class Two_dimensional_arraysTests
    {
        [TestCase(new int[,] { { 1, 45, 24, 42 }, { 89, 4, 32, 34 } }, 1 )]
        [TestCase()]
        [TestCase()]
        public void Test1(int[,] array, int expected)
        {
            int actual = Two-dimensional_arrays.Task1(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
