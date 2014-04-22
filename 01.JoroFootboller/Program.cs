/* Problem 1. Joro The Football Player
 */

using System;

class Program
{
    static void Main()
    {
        int isLeap = (Console.ReadLine() == "t") ? 3 : 0;
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        double answer = 0;

        answer = 0.5 * holidays;
        answer += ((2.0 / 3.0) * (52.0 - hometown)) * 1.0;
        answer += hometown * 1 + isLeap;

        Console.WriteLine(Math.Truncate(answer));
    }
}