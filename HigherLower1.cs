using System;
using System.Collections.Generic;

class GuessingGame
{
  private int index;
  public int ComputerGuess { get; }
  public int UserInput { get; }
  private bool isDone;

  public GuessingGame(string userInput)
  {
    UserInput = userInput;
    ComputerGuess = 50;
    index = 0;
    isDone = false;
  }

  public void PlayGame()
  {
    while(isDone)
    {

    }
  }

  private void MakeAGuess()
  {
    Console.WriteLine("(higher/lower)Is your number higher or lower than " + ComputerGuess);
    string response = Console.ReadLine();

    if(response == "higher")
    {
      
    }
    else if(response == "lower")
    {

    }
  }
}
class Program
{
  public static void Main()
  {
    Console.WriteLine("Play My Game:");
    string response = Console.ReadLine();
    GuessingGame newGuessingGame = new GuessingGame(response);



  }
}
