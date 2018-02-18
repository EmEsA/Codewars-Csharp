//https://www.codewars.com/kata/58878393fc23972533001434


//linq----------------------------------------
using System;
using System.Linq;
public class Kata {

  public bool IsPrime(int number) {
    return Enumerable.Range(1, (Math.Abs(number) / 2)).Select(x => Math.Abs(number) % x).Count(y => y == 0) == 1 ? true: false;
  }
}

//recursion-----------------------------------
using System;
public class Kata {

  public bool IsPrime(int number) {   
    return (number == 0 || number == 1) ? false : CountDeviders(Math.Abs(number), 0, Math.Abs(number) / 2) == 1 ? true : false;
  }
  public static int CountDeviders(int number, int deviderCount, int x)
        {
            deviderCount = deviderCount + ((number % x == 0) ? 1: 0);
            return x == 1 ? deviderCount : CountDeviders(number, deviderCount, x - 1);
        }
}