//https://www.codewars.com/kata/55e6f5e58f7817808e00002e

using System;

public class DivSeven
{
	public static long[] Seven(long m)
	{
    int i = 0;
    while (m >= 100 && m != 0)
    {
      i++;
      m = Convert.ToInt32(m.ToString().Substring(0, m.ToString().Length - 1)) - 2 * Convert.ToInt32(m.ToString().Substring(m.ToString().Length - 1, 1));
    } 
    return new long[] { m, i };
	}
}