using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_EmptyString_Returns0()
        {
            int result = Str.CamelCase("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_SingleWordLowercase_Returns1()
        {
            int result = Str.CamelCase("word");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            int result = Str.CamelCase("saveChangesInTheEditor");
            Assert.AreEqual(5, result); // save Changes In The Editor
        }

        [Test]
        public void CamelCase_AllLowercase_Returns1()
        {
            int result = Str.CamelCase("hello");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_FirstLetterUppercase_ReturnsCorrectCount()
        {
            int result = Str.CamelCase("SaveChangesInEditor");
            Assert.AreEqual(4, result);
        }
    }
}
