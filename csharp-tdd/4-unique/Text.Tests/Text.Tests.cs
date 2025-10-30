using NUnit.Framework;
using Text; // IMPORTANT: Must match the namespace in Text.cs

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        // Updated test: expects -1 since there are no unique characters
        [Test]
        public void UniqueChar_Abcabc_ReturnsMinus1()
        {
            int result = Str.UniqueChar("abcabc");
            Assert.AreEqual(-1, result); // No unique character
        }

        [Test]
        public void UniqueChar_Bbccdde_Returns6()
        {
            int result = Str.UniqueChar("bbccdde");
            Assert.AreEqual(6, result); // First unique char is 'e' at index 6
        }

        [Test]
        public void UniqueChar_AllRepeats_ReturnsMinus1()
        {
            int result = Str.UniqueChar("aabbcc");
            Assert.AreEqual(-1, result); // No unique character
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinus1()
        {
            int result = Str.UniqueChar("");
            Assert.AreEqual(-1, result); // Empty string returns -1
        }

        [Test]
        public void UniqueChar_SingleCharacter_Returns0()
        {
            int result = Str.UniqueChar("z");
            Assert.AreEqual(0, result); // Single char is unique at index 0
        }
    }
}
