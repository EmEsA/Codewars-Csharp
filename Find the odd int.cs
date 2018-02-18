//https://www.codewars.com/kata/54da5a58ea159efa38000836

using System.Linq;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        return seq.GroupBy(x => x).Single(group => group.Count() % 2 != 0).Key;
      }
       
    }
}