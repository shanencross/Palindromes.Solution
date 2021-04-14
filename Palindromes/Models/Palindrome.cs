using System;
namespace Palindromes.Models {
  public class Palindrome {
    public static bool IsPalindrome(string input) 
    {
      for (int i = 0; i < (input.Length / 2); i++) 
      {
        char charFromStart = input[i];
        char charFromEnd = input[input.Length - 1 - i];

        if (charFromStart != charFromEnd)
        {
          return false;
        }
      }
      return true;
    }
  }
}