//https://www.codewars.com/kata/5592e3bd57b64d00f3000047

using System;
public class ASum {
	
  public static long findNb(long m)
  {
    long sum = 0;
    long n = 0;
    for (long i = 1; i < m; i++)
    {
      sum += Convert.ToInt64(i * i * i);
      if (sum >= m)
      {
        n = i;
        break;
      }
    }
    return (sum == m) ? n : -1;
  }
}