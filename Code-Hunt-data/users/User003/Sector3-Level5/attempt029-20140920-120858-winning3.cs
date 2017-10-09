using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		System.Collections.Generic.List<int[]> arrayList = new System.Collections.Generic.List<int[]>();
		int aX;
		int bY;
		for(int a = -2;a<=2;a++)
			for(int b = -2;b<=2;b++)
			{
				if((Math.Abs(a)+Math.Abs(b))!=3)continue;
				if(a==0)continue;
				aX = x+a;
				bY = b+y;
				if(isGood(aX)&&isGood(bY))
				{
					arrayList.Add(new int[]{aX,bY});
				}
			}
			return arrayList.ToArray();
			
	}
		public static bool isGood(int x)
	{
		if(x>0&&x<=8)
		{
			return true;
		}
		return false;
	}
    
}