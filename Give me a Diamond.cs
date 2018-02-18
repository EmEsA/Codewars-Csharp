//https://www.codewars.com/kata/5503013e34137eeeaa001648

using System;

public class Diamond
{
    public static string print(int n)
    {
        if (n < 0 || n % 2 == 0) return null;

        string top = "";
        string bottom = "";
        string middle = new string('*', n) + "\n";

        for (int i = 1; i <= Math.Floor((double)n / 2); i++)
        {
            top += new string(' ', n / 2 - (i - 1)) + new string('*', i * 2 - 1) + "\n";
            bottom += new string(' ', i) + new string('*', n - (2 * i)) + "\n";
        }
        return top + middle + bottom;
    }
}