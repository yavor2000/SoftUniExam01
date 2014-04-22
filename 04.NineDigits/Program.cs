/* Problem 4. Nine Digits Magic Numbers
 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        //int[] N = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        //Console.WriteLine(DateTime.Now);
        forloop(9, sum, diff);
        /*variationsString(N, 9, sum, diff);
        Console.WriteLine(DateTime.Now);
        variate(9, sum, diff);*/
        //Console.WriteLine(DateTime.Now);

    }

    private static void forloop(int p, int sum, int diff)
    {
        int count = 0;
        for (int d1 = 1; d1 < 8; d1++)
            for (int d2 = 1; d2 < 8; d2++)
                for (int d3 = 1; d3 < 8; d3++)
                    for (int d4 = 1; d4 < 8; d4++)
                        for (int d5 = 1; d5 < 8; d5++)
                            for (int d6 = 1; d6 < 8; d6++)
                                for (int d7 = 1; d7 < 8; d7++)
                                    for (int d8 = 1; d8 < 8; d8++)
                                        for (int d9 = 1; d9 < 8; d9++)
                                        {
                                            int sumAll = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9;
                                            if (sum == sumAll)
                                            {
                                                int left = (d1*100 + d2*10 + d3);
                                                int mid = (d4*100+ d5*10+d6);
                                                int right = (d7*100 +d8*10+d9);
                                                if ( ((mid - left) == diff && (right - mid) == diff) && (left<=mid && mid<=right) )
                                                {
                                                    Console.WriteLine(left*1000000+mid*1000+right);
                                                    count++;
                                                }
                                            }
                                        }
        if (count == 0) Console.WriteLine("No");
    }

    private static void variate(int p, int sum, int diff)
    {
        int max = int.Parse(new string('7', p));
        int min = int.Parse(new string('1', p));
        //min = 125171217;
        int count = 0;
        for (int i = min; i <= max; i++)
        {
            /*if (i.ToString().IndexOf('0') > -1) continue;
            if (i.ToString().IndexOf('8') > -1) continue;
            if (i.ToString().IndexOf('9') > -1) continue;*/
            if (sum == sumDigits(i))
            {
                int left = (i / 1000000);
                int mid = (i - left * 1000000) / 1000;
                if (mid<left) continue;
                int right = (i - left * 1000000 - mid * 1000);
                if (right<mid) continue;
                if ((mid - left) == diff && (right - mid) ==diff)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
        }
        if (count == 0) Console.WriteLine("No");
    }
    public static int sumDigits(int num)
    {
        int answer = 0;
        int digit = 0;
        while (num > 0)
        {
            digit = num % 10;
            if (digit == 0 || digit == 8 || digit == 9) return -1;
            answer += digit;
            num /= 10;
        }
        return answer;
    }
    public static void variationsString(int[] num, int n, int sum, int diff)
    {
        if (n <= 0) return;
        if (num.GetLength(0) < 0) return;
        StringBuilder tmp = new StringBuilder();
        int size = num.GetLength(0);
        int[] a = new int[n];
        int count = 0;
        int sumAll = 0;
        int leftsum = 0, midsum = 0, rightsum = 0;
        int pos = n - 1;
        int next = 0;

        for (int i = 0; i < n; i++) { a[i] = num[0]; }

        while (pos >= 0)
        {
            if (a[pos] < num[size - 1])
            {

                a[pos] = num[next];
                next++;
                for (int i = 0; i < n; i++) { tmp.Append(a[i].ToString()); sumAll += a[i]; }
                if (n == 9)
                {
                    leftsum = a[0] * 100 + a[1] * 10 + a[2];
                    midsum = a[3] * 100 + a[4] * 10 + a[5];
                    rightsum = a[6] * 100 + a[7] * 10 + a[8];
                }
                if (sumAll == sum && (Math.Abs(midsum - leftsum) == Math.Abs(rightsum - midsum))
                    && (Math.Abs(rightsum - midsum) == Math.Abs(diff))
                    && (leftsum < midsum || midsum < rightsum)) { Console.WriteLine(tmp); count++; }
                tmp.Remove(0, tmp.Length);
                leftsum = -2; rightsum = -3; midsum = -1;
                sumAll = 0;
            }
            else
            {
                pos--;
                if (pos >= 0)
                {
                    next = a[pos] - 1;
                    if (a[pos] < num[size - 1])
                    {
                        a[pos] = num[next + 1];
                        for (int i = pos + 1; i < n; i++) { a[i] = num[0]; }
                        for (int i = 0; i < n; i++) { tmp.Append(a[i].ToString()); sumAll += a[i]; }
                        if (n == 9)
                        {
                            leftsum = a[0] * 100 + a[1] * 10 + a[2];
                            midsum = a[3] * 100 + a[4] * 10 + a[5];
                            rightsum = a[6] * 100 + a[7] * 10 + a[8];
                        }
                        if (sumAll == sum && (Math.Abs(midsum - leftsum) == Math.Abs(rightsum - midsum))
                    && (Math.Abs(rightsum - midsum) == Math.Abs(diff))
                    && (leftsum < midsum || midsum < rightsum)) { Console.WriteLine(tmp); count++; }
                        tmp.Remove(0, tmp.Length);
                        leftsum = -2; rightsum = -3; midsum = -1;
                        sumAll = 0;
                        pos = n - 1;
                        next = num[0];
                    }
                }

            }
        }
        if (count == 0) Console.WriteLine("No");
    }

}