//https://www.codewars.com/kata/5467e4d82edf8bbf40000155

using System;
using System.Linq;
public static class Kata
{
  public static int DescendingOrder(int num)
  {
    return Convert.ToInt32(String.Join("",num.ToString().OrderBy(x => -x)));
  }
}