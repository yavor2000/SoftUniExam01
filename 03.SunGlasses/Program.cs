/* Problem 3. SunGlasses 
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mid = n / 2;//((n-1) / 2 + 1);
        string fl = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
        string bm = "*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*";
        string m = "*" + new string('/', 2 * n - 2) + "*" + new string('|', n) + "*" + new string('/', 2 * n - 2) + "*";

        Console.WriteLine(fl);
        for (int i = 1; i < n - 1; i++)
        {
            if (i == mid) Console.WriteLine(m);
            else if (n > 2) Console.WriteLine(bm);
        }
        Console.WriteLine(fl);
    }
}