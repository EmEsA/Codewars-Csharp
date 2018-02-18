//https://www.codewars.com/kata/520b9d2ad5c005041100000f

using System;

public class Kata
{
  public static string PigIt(string str)
  {
    string[] arr = str.Split(' ');
    for (int i=0;i<arr.Length;i++){
      arr[i] = arr[i].Substring(1) + arr[i].Substring(0,1) + "ay";
    }
    return String.Join(" ",arr);
  }
}