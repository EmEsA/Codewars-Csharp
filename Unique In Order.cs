//https://www.codewars.com/kata/54e6533c92449cc251001667

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
    return iterable.Where((x, i) => i == iterable.Count() -1 || !x.Equals(iterable.ElementAt(i + 1) ));
  }
}