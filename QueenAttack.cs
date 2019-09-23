using System;
using System.Collections.Generic;



public class Coordinate {
  public int X { get; set; }
  public int Y { get; set; }
  public Coordinate(int x, int y)
  {
    X = x;
    Y = y;
  }
}

class Program
{
  static void Main()
  {
  // get location of queen from user
   // get x coordinate from user
   Console.WriteLine("Enter the x coordinate for the Queen:");
   int x = int.Parse(Console.ReadLine());
   // get y coordinate from user
   Console.WriteLine("enter the y coordinate for the Queen:");
   int y = int.Parse(Console.ReadLine());
   Coordinate queen = new Coordinate(x,y);

   // get location of pawn from user
  // get x coordinate from user
    Console.WriteLine("Enter the x coordinate for the pawn:");
    x = int.Parse(Console.ReadLine());
    // get y coordinate from user
    Console.WriteLine("enter the y coordinate for the pawn:");
    y = int.Parse(Console.ReadLine());
    Coordinate pawn = new Coordinate(x,y);

    Console.WriteLine(queen.X);
   //check if the queen can attack it

    //if their x or y is the same print out it can attack
    if (queen.X == pawn.X || queen.Y == pawn.Y) {
      Console.WriteLine("Queen can attack");
    } else {
      Console.WriteLine("Queen cannot attack");
    }

    //if it is on a diagonal with the queen the queen can attack it
      //create a new coordiante object called "diagonalScanner" that starts at the Queen

      Coordinate Scanner = new Coordinate(queen.X, queen.Y);
      


      //while the scanner is in bounds
        //check up and to the right by adding one todiagonalScanner x and y
          //if a match is made show result
        //if no match set the scanner back to queen and scan a different direction


   //display result
  }
}
