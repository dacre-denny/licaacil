using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lica_lib;

namespace lica_testsuite
{
    [TestClass]
    public class TestSuitePalindromes
    {
        [TestMethod]
        public void Palindrome_MultiCharEvenLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeInAnagramOf("anna"));
        }

        [TestMethod]
        public void Palindrome_SingleCharEvenLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeInAnagramOf("aaaaaaaa"));
        }

        [TestMethod]
        public void AnagramOfPalindrome_MultiCharOddLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeInAnagramOf("aaaaaaaab"));

            Assert.IsTrue(Palindromes.isPalindromeInAnagramOf("igdedgide"));
        }

        [TestMethod]
        public void NonPalindrome_MultiCharEvenLength_Expect_False()
        {
            Assert.IsFalse(Palindromes.isPalindromeInAnagramOf("caaaaaaaab"));

            Assert.IsFalse(Palindromes.isPalindromeInAnagramOf("owefhijpfwai"));
        }

        [TestMethod]
        public void Palindrome_MultiCharOddLength_Expect_True()
        {
            Assert.IsTrue(Palindromes.isPalindromeInAnagramOf("donotbobtonod"));
        }
    }
}
