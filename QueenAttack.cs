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

public class Queen {
  public int X { get; set; }
  public int Y { get; set; }
  public Queen(int x, int y)
  {
    X = x;
    Y = y;
  }

  public bool canAttackMethod(Coordinate pawn)
  {
    bool canAttack = false;
    //does comparison between pawn coordinates and queen coordinates
    if (this.X == pawn.X || this.Y == pawn.Y) {
      canAttack = true;
    }
    Coordinate scanner = new Coordinate(this.X, this.Y);
    //scan up and right
    while(scanner.X <= 7 && scanner.Y <= 7)
    {
      scanner.X++;
      scanner.Y++;
      if(scanner.X == pawn.X && scanner.Y == pawn.Y)
      {
        canAttack = true;
      }
    }
    //scan up left
    scanner.X = this.X;
    scanner.Y = this.Y;
    while(scanner.X >= 2 && scanner.Y <= 7)
    {
      scanner.X--;
      scanner.Y++;
      if(scanner.X == pawn.X && scanner.Y == pawn.Y)
      {
        canAttack = true;
      }
    }
    //scan down left
    scanner.X = this.X;
    scanner.Y = this.Y;
    while(scanner.X >= 2 && scanner.Y >= 2)
    {
      scanner.X--;
      scanner.Y--;
      if(scanner.X == pawn.X && scanner.Y == pawn.Y)
      {
        canAttack = true;
      }
    }
    //scan down right
    scanner.X = this.X;
    scanner.Y = this.Y;
    while(scanner.X <= 7 && scanner.Y >= 2)
    {
      scanner.X++;
      scanner.Y--;
      if(scanner.X == pawn.X && scanner.Y == pawn.Y)
      {
        canAttack = true;
      }
    }
    return canAttack;
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
   //create queen object instance
   Queen queenObject = new Queen(x,y);

   // get location of pawn from user
  // get x coordinate from user
    Console.WriteLine("Enter the x coordinate for the pawn:");
    x = int.Parse(Console.ReadLine());
    // get y coordinate from user
    Console.WriteLine("enter the y coordinate for the pawn:");
    y = int.Parse(Console.ReadLine());
    Coordinate pawn = new Coordinate(x,y);

    //call can attack method
    queenObject.canAttackMethod(pawn);
    //display the result to the user
    Console.WriteLine(queenObject.canAttackMethod(pawn));






  }
}
