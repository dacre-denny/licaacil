using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lica_lib;

namespace lica_testsuite
{
    [TestClass]
    public class TestSuitePalindromes
    {
        [TestMethod]
        public void isAnagramOfPalindrome_MultiCharEvenLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isAnagramOfPalindrome("anna"));
        }

        [TestMethod]
        public void isAnagramOfPalindrome_SingleCharEvenLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isAnagramOfPalindrome("aaaaaaaa"));
        }

        [TestMethod]
        public void isAnagramOfPalindrome_MultiCharOddLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isAnagramOfPalindrome("aaaaaaaab"));

            Assert.IsTrue(Palindromes.isAnagramOfPalindrome("igdedgide"));
        }

        [TestMethod]
        public void isAnagramOf_NonPalindromeMultiCharEvenLength_Expect_False()
        {
            Assert.IsFalse(Palindromes.isAnagramOfPalindrome("caaaaaaaab"));

            Assert.IsFalse(Palindromes.isAnagramOfPalindrome("owefhijpfwai"));
        }

        [TestMethod]
        public void isAnagramOf_MultiCharOddLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isAnagramOfPalindrome("donotbobtonod"));
        }
    }
}
