using NUnit.Framework;
using Library;

namespace LibraryTests
{
    public class ProgramTests
    {
        [Test]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 7)]
        [TestCase(10, ExpectedResult = 6)]
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(345, ExpectedResult = 125)]
        [TestCase(72, ExpectedResult = 22)]
        public static int FixedTest(int num)
        {
            return Program.Collatz(num);
        }
    }
}
