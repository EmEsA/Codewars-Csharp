//https://www.codewars.com/kata/566fc12495810954b1000030

using System;
using System.Collections;
using System.Linq;

public class CountDig 
{ 
    public static int NbDig(int n, int d) 
    {
      IEnumerable squares = Enumerable.Range(0, n + 1).Select(x => x * x);
      int result = 0;
      foreach (int num in squares)
      {
        result += num.ToString().Count(x => Char.GetNumericValue(x) == d);
      }
      return result;
    }
}