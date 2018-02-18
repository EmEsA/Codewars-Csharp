//https://www.codewars.com/kata/56e9e4f516bcaa8d4f001763

public class SequenceSum
{
  public static string ShowSequence(int n)
  {    
    if (n < 0) {
      return n + "<" + 0;
    } else if (n == 0) {
      return "0=0";
    } else {
      string output = "0";
      int result = 0;
      for (int i = 1; i <= n; i++) {
        result += i;
        output += "+" + i;
      }
      return output + " = " + result;
    }
  }
}