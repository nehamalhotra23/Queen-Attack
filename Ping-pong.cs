using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string stringNumber = Console.ReadLine();
    int intNumber = int.Parse(stringNumber);
    // program code goes here
    for (int index = 0; index <= intNumber; index++)
    {
      if(index % 3 == 0 && index % 5 == 0 ) {
        Console.WriteLine("ping pong");
      }
    }
  }
}
