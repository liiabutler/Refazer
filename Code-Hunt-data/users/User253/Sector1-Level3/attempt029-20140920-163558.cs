using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x!=false) return true;
else if((y!=false)&&(z!=false)&&(y==z)) return true;
else return false;
  }
}