//https://www.codewars.com/kata/54b42f9314d9229fd6000d9c

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string output = "";
    foreach (char ch in word)
    {
      string rep = char.ToString(ch).ToUpper();
      if (word.Length - word.ToUpper().Replace(rep,"").Length > 1){
        output += ")";
      }else{
        output += "(";
      }
    }
    return output;
  }
}