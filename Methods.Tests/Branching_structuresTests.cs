using NUnit.Framework;

namespace Methods.Tests
{
    public class Branching_structuresTests
    {
        [TestCase(6, 5, 11)]
        [TestCase(5, 5, 25)]
        [TestCase(5, 6, -1)]
        public void Test1(int a, int b, int expected)
        {
            int actual = Branching_structures.Task1(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 5, "Первая четверть")]
        [TestCase(10, -2, "Четвертая четверть")]
        [TestCase(-8, -4, "Третья четверть")]
        public void Test2(int x, int y, string expected)
        {
            int actual = Branching_structures.Task2(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 5, 7, "3 5 7")]
        [TestCase(4, 1, 10, "1 4 10")]
        [TestCase(9, 5, 2, "2 5 9")]
        public void Test3(int a, int b, int c, string expected)
        {
            int actual = Branching_structures.Task3(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -6, -7, "У уравнения два корня: 7, -1")]
        [TestCase(1, -8, -9, "У уравнения два корня: 9, -1")]
        [TestCase(1, -1, -2, "У уравнения два корня: 2, -1")]
        public void Test4(int a, int b, int c, string expected)
        {
            int actual = Branching_structures.Task4(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, "одиннадцать")]
        [TestCase(43, "сорок три")]
        [TestCase(65, "шестьдесят пять")]
        public void Test5(int a, string expected)
        {
            int actual = Branching_structures.Task5(a);

            Assert.AreEqual(expected, actual);
        }







        //NegativeTests

        [TestCase(3, 1, 5)]
        [TestCase(2, 4, 6)]
        [TestCase(2, 7, 4)]
        public void Test4Exception(int a, int b, int c)
        {
            try
            {
                Branching_structures.Task4(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
