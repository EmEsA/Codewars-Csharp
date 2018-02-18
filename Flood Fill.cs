//https://www.codewars.com/kata/5576f6719988e71ea30000ae

using System;
using System.Collections.Generic;

public class Kata
{
        public static int[,] FloodFill(int[,] array, int y, int x, int newValue)
        {
            Stack<int[]> stack = new Stack<int[]>();
            int initialValue = array[y, x];

            stack.Push(new int[] { y, x });

            while (stack.Count > 0)
            {
                int[] point = stack.Pop();
                if (array[point[0], point[1]] == initialValue)
                {
                    array[point[0], point[1]] = newValue;
                    if (point[0] - 1 >= 0) stack.Push(new int[] { point[0] - 1, point[1] });
                    if (point[1] - 1 >= 0) stack.Push(new int[] { point[0], point[1] - 1 });
                    if (point[0] + 1 <= array.GetUpperBound(0)) stack.Push(new int[] { point[0] + 1, point[1] });
                    if (point[1] + 1 <= array.GetUpperBound(1)) stack.Push(new int[] { point[0], point[1] + 1 });
                }
            }
            return array;
        }
}