

public class Program {
    public static int Puzzle(int[] a) {
      int result = 0;
	  for(int i = 0, n = a.length; i < n; i++)
	  {
		  result = result + a[i];
	  }
	  return result;
    }
}