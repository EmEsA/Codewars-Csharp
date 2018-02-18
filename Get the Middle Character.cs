//https://www.codewars.com/kata/56747fd5cb988479af000028

using System;
public class Kata
{
  public static string GetMiddle(string s)
  {
    decimal letterCount = s.Length;
    int pos = Convert.ToInt32(Math.Ceiling(letterCount / 2))-1;
    int num = letterCount % 2 != 0 ? 1 : 2;
    return s.Substring(Convert.ToInt32(pos), num);
  }
}