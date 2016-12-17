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
                
                if (Palindromes.isAnagramOfPalindrome(input))
                {
                    Func<string, bool> isPalindrome = str => {

                        if (String.IsNullOrEmpty(str))
                        {
                            return false;
                        }

                        int halfLength = (int)Math.Ceiling(str.Length / 2f);

                        for (int i = 0; i < halfLength; i++)
                        {
                            var c = str.ElementAt(i);
                            var rc = str.ElementAt(str.Length - 1 - i);

                            if (c != rc)
                            {
                                return false;
                            }
                        }

                        return true;
                    };

                    result = isPalindrome(input) ? "is palindrome" : "is anagram of a palindrome";
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
