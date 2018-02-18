//https://www.codewars.com/kata/52f78966747862fc9a0009ae

using System;
using System.Data;
using System.Linq;

public class Calc
{
    public double evaluate(String expr)
    {
        return double.Parse(recursion(expr));
    }

    public static string recursion(string expr)
    {
        double d;
        if (expr == "") return "0";
        if (double.TryParse(expr, out d)) return expr;

        var arr = expr.Split(' ');
        for (int i = 0; i < arr.Length; i++)
        {
            if (!double.TryParse(arr[i], out d))
            {
                arr[i] = Convert.ToString(new DataTable().Compute(arr[i - 2] + arr[i] + arr[i - 1], null));
                return recursion(arr.Where((x, ind) => ind != i - 2 && ind != i - 1).Aggregate((prev, curr) => prev += ' ' + curr));
            }
        }
        return arr[arr.Length - 1].ToString();
    }
}