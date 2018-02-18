//https://www.codewars.com/kata/59437bd7d8c9438fb5000004

using System;
using System.Text.RegularExpressions;
using System.Linq;

 public class Kata
 {
        public static string AlphabetWar(string b)
        {
            return b.Contains("#")
            ? Regex.Matches(b, @"(?<=([^\[\]]*))(\[)([^\[\]]+)(\])([^\[\]]*)")
                .Cast<Match>()
                .Where(match => (match.Groups[1].Value + match.Groups[5].Value).Count(ch => ch == '#') < 2)
                .Select(match => match.Groups[3].Value)
                .Aggregate("", (prev, curr) => prev += curr)
            : Regex.Replace(b, @"[\[\]#]", "");
        }
}