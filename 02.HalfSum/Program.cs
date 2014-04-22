/* Problem 2. HalfSum
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sumLeft = 0, sumRight = 0;
        for (int i = 0; i < n; i++)
        {
            sumLeft += int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sumRight += int.Parse(Console.ReadLine());
        }
        if (sumLeft == sumRight) Console.WriteLine("Yes, sum={0}", sumLeft);
        else Console.WriteLine("No, diff={0}", Math.Abs(sumLeft-sumRight));
    }
}