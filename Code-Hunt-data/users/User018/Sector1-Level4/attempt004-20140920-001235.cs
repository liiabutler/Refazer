using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return (x==y)||(x==(y-1))||(x==(y+1));
  }
}