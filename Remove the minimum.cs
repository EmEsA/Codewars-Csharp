//https://www.codewars.com/kata/563cf89eb4747c5fb100001b

using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    List<int> result = new List<int>(numbers);
    var pos = result.FindIndex(x => x == result.Min());
    if (pos != -1) result.RemoveAt(pos);
    return result;
  }
}