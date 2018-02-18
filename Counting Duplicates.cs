//https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1

using System;
using System.Linq;
public class Kata
{
  public static int DuplicateCount(string str)
  {
    return str.ToLower().GroupBy(x => x).Count(y => y.Count() > 1);
  }
}