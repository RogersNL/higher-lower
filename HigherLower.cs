using System;
using System.Collections.Generic;

class HigherLower
{
  public int guessNumber;
  public int previousGuessNumber;
  public HigherLower (int someNumber)
  {
    guessNumber = someNumber;
  }

  public int Guess(int playerGuess)
  {
    Console.WriteLine("Is your number higher or lower than " + guessNumber + "? (Higher/Lower/Correct)");
    string reply = Console.ReadLine();
    if (reply == "Higher" || reply == "higher")
    {
      guessNumber = guessNumber + (100 - guessNumber)/2;
      return guessNumber;
    }
    else if (reply == "Lower" || reply == "lower")
    {
      guessNumber = guessNumber - (100 - guessNumber)/2;
      return guessNumber;
    }
    else if (reply == "Correct" || reply == "correct")
    {
      Console.WriteLine("Your number is " + guessNumber + ". Want to play again? (Y/N)");
      string playAgain = Console.ReadLine();
      if(playAgain == "Y" || playAgain == "y")
      {
        return 0;
      }
      else
      {
        Console.WriteLine("cy@");
        return 101;
      }
    }
    else
    {
      Console.WriteLine("Seriously?");
        return guessNumber;
    }
  }
}
// 
// public class Program
// {
//   public static void Main()
//   {
//     HigherLower newHigherLower = new HigherLower (50);
//     Console.WriteLine("Would you like to play a higher/lower game? (yes/no)");
//     string answer = Console.ReadLine();
//     if (answer == "yes" || answer == "Yes")
//     {
//       Console.WriteLine("Ok");
//       new HigherLower(newHigherLower.Guess());
//     }
//     else
//     {
//       Console.WriteLine("Too bad");
//       new HigherLower(newHigherLower.Guess());
//     }
//     if (newHigherLower.Guess() == 101)
//     {
//       Main();
//     }
//     else if (newHigherLower.Guess() > 0)
//     {
//       new HigherLower(newHigherLower.Guess());
//     }
//
//   }
// }
