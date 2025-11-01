using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            int result = Operations.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            int result = Operations.Add(-2, -3);
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            int result = Operations.Add(5, -3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Add_Zero_ReturnsOtherNumber()
        {
            Assert.AreEqual(7, Operations.Add(0, 7));
            Assert.AreEqual(7, Operations.Add(7, 0));
        }
    }
}
