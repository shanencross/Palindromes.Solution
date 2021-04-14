using System;
using Palindromes.Models;

namespace Palindromes {
  public class Program {
    public static void Main() 
    {
      bool isGameRunning = true;
      Console.WriteLine("Palindromes!");
      Console.WriteLine("They're words that look the same, whether you read them backwards or forwards!");
        
      while (isGameRunning) { 
        Console.WriteLine("Enter a word, and we'll tell you whether it's a palindrome or not: ");

        string userInput = Console.ReadLine();

        bool isPalindrome = Palindrome.IsPalindrome(userInput);

        if (isPalindrome) 
        {
          Console.WriteLine("Yep, it's a palindrome all right!");
        }
        else
        {
          Console.WriteLine("Nope, not a palindrome. How boring.");
        }

        Console.WriteLine("Would you like to go again? (y/n)");
        string continueInput = Console.ReadLine();
        Console.WriteLine();
        if (continueInput != "y")
        {
          isGameRunning = false;
        }
      }
    }
  }
}