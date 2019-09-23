using System;
using System.Collections.Generic;

class Program
{
  public static Dictionary<string, string> riddles = new Dictionary<string, string>()
  {
    {"What 8 letter word can have a letter taken away and it still makes a word. Take another letter away and it still makes a word. Keep on doing that until you have one letter left. What is the word?", "starting"},
    {"The more you take, the more you leave behind. What am I?", "footsteps"},
    {"What has a head, a tail, is brown, and has no legs?", "penny"}
  };

static int RandomNumber(int min, int max)
  {
    Random random = new Random();
    return random.Next(min,max);
  }

  static void Main()
  {
    string nextRiddle = "y";
    while(nextRiddle == "y")
    {
      Console.WriteLine("Welcome to the Riddles of the Sphinx");
        //generate random number
       int random = RandomNumber(0,3);
       List<string> keyList = new List<string>(riddles.Keys);
       string randomKey = keyList[random];
       //show a riddle
       Console.WriteLine(randomKey);
       //get an answer from the user
       string stringInput = Console.ReadLine();
       //compare user input to answer

       //give result

       //ask to continue
       Console.WriteLine("continue?: y for yes, q for quit");
       nextRiddle = Console.ReadLine();
    }
  }
}
