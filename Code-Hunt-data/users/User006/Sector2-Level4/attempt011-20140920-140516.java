

public class Program {
  public static int Puzzle(int a, int b) {
    while (a != b) {
		if (a > b)
			a -= b;
		else
			b -= a;
	}
	return a;
  }
}