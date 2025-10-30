using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_ValidList_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 5, 3, 9, 2 };
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            List<int> nums = null;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -5, -1, -8 };
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }
    }
}
