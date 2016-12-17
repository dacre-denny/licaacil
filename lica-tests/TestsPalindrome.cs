using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lica_lib;

namespace lica_testsuite
{
    [TestClass]
    public class TestSuitePalindromes
    {
        [TestMethod]
        public void isPalindromeOrAnagramOfPalindrome_MultiCharEvenLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeOrAnagramOfPalindrome("anna"));
        }

        [TestMethod]
        public void isPalindromeOrAnagramOfPalindrome_SingleCharEvenLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeOrAnagramOfPalindrome("aaaaaaaa"));
        }

        [TestMethod]
        public void isPalindromeOrAnagramOfPalindrome_MultiCharOddLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeOrAnagramOfPalindrome("aaaaaaaab"));

            Assert.IsTrue(Palindromes.isPalindromeOrAnagramOfPalindrome("igdedgide"));
        }

        [TestMethod]
        public void isAnagramOf_NonPalindromeMultiCharEvenLength_Expect_False()
        {
            Assert.IsFalse(Palindromes.isPalindromeOrAnagramOfPalindrome("caaaaaaaab"));

            Assert.IsFalse(Palindromes.isPalindromeOrAnagramOfPalindrome("owefhijpfwai"));
        }

        [TestMethod]
        public void isAnagramOf_MultiCharOddLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeOrAnagramOfPalindrome("donotbobtonod"));
        }

        #region Other test cases to consider
        /*
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Null_Expect_ArgumentNullException()
        {
            Helpers.isPalindromeInAnagramOf(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Empty_Expect_ArgumentException()
        {
            Helpers.isPalindromeInAnagramOf(String.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsWhiteSpace_Expect_ArgumentException()
        {
            Helpers.isPalindromeInAnagramOf(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HasWhiteSpaces_Expect_ArgumentException()
        {
            Helpers.isPalindromeInAnagramOf("a n n a");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotLowerCase_Expect_ArgumentException()
        {
            Helpers.isPalindromeInAnagramOf("aNnA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotAlphaOnly_Expect_ArgumentException()
        {
            Helpers.isPalindromeInAnagramOf("6nn@");
        }
        */
        #endregion
    }
}
