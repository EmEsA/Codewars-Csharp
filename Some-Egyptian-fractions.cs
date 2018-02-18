//https://www.codewars.com/kata/54f8693ea58bce689100065f

using System;
using System.Collections.Generic;
using System.Linq;

public class Decomp
{
    public static string Decompose(string nrStr, string drStr)
    {
        double numerator = double.Parse(nrStr);
        double denominator = double.Parse(drStr);
        double reminder;
        string result = "";

        if (numerator == 0) return "[]";

        if (numerator > denominator)
        {
            if (numerator % denominator == 0) return $"[{numerator / denominator}]";
            result += $", {Math.Floor(numerator / denominator).ToString()}";
            numerator = numerator % denominator;
        }
        
        do
        {
            reminder = Math.Ceiling(denominator / numerator);
            result += $", 1/{reminder}";
            numerator = numerator * reminder - denominator;
            denominator = denominator * reminder;
        } while ((numerator >= 1));

        return "[" + result.Substring(2) + "]";
    }
}