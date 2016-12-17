using lica_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lica_app
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new ArgumentException("Input string required");
                }

                string input = args[0], result = "";
                
                if (Palindromes.isPalindromeOrAnagramOfPalindrome(input))
                {
                    int halfLength = (int)Math.Ceiling(input.Length / 2f);
                    bool isSymmetric = true;

                    for (int i = 0; i < halfLength; i++)
                    {
                        int revI = input.Length - 1 - i;

                        if (input.ElementAt(i) != input.ElementAt(revI))
                        {
                            isSymmetric = false;
                            break;
                        }
                    }

                    result = isSymmetric ? "is palindrome" : "is anagram of a palindrome";
                }
                else
                {
                    result = "is neither palindrome, nor anagram of a palindrome";
                }

                Console.WriteLine("Input string '{0}' {1}", input, result);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("EXCEPTION: Invalid program argument. {0}", exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("EXCEPTION: Program error. {0}", exception.Message);
            }
        }
    }
}
