using System;



class MainClass
{

private static int gold = 100;

  public static void Main (string[] args)
  {
    
      //do while used when we don't know how much to repeat
      //for: when we know how much to repeat

    ShellGame();

  }

  public static void ShellGame()
  {
      Console.WriteLine("There is a gem under 1 of 3 shells.");
      Console.WriteLine("Guess correctly and win 20 gold.");
      Console.WriteLine("You can play 5 times for a wager of 50.");

      gold -= 50;
      Console.WriteLine("\n\rYour balance: " + gold + "\n\r");
      
      for (int i = 0; i < 5; i++)
      {
        int cup = new Random().Next(1,4);
        /*Console.WriteLine("Cheat; " + cup);*/

        Console.Write("Which shell? (1, 2, 3,): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == cup)
        {
          Console.WriteLine("You guessed correctly! You win 20 gold!");
          gold += 20;
        }
        else 
        {
          Console.WriteLine("You guessed incorrectly! L.");
        }

        Console.WriteLine("\n\rYour balance: " + gold +"\n\r");
      }

  }
}