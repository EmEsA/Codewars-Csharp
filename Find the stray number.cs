//https://www.codewars.com/kata/57f609022f4d534f05000024

using System.Linq;
class Solution 
{
  public static int Stray(int[] numbers)
  {
    int same = (numbers[0] == numbers[2]) ? numbers[1] : (numbers[0] == numbers[1]) ? numbers[0] : numbers[1];
    return  numbers.Sum() + same - numbers.Length * same;
  }
}