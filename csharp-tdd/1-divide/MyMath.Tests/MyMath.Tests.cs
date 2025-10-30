using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] expected = { { 1, 2 }, { 3, 4 } };

            var result = MyMath.Matrix.Divide(matrix, 2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            var result = MyMath.Matrix.Divide(matrix, 0);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = MyMath.Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }
    }
}


