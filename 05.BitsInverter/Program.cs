/* Problem 5. Bits Inverter
 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        StringBuilder path = new StringBuilder();
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
            path.Append(Convert.ToString(num[i], 2).PadLeft(8, '0'));
        }
        int[] bits = new int[path.Length];
        for (int i = 0; i < path.Length; i++) bits[i] = 1 + i * step;
        int count = 0;
        for (int index = 0; index < path.Length; index++)
        {
            if (index == bits[count]-1)
            {
                result.Append(path[index]=='0'?'1':'0');
                count++;
            }
            else result.Append(path[index]);
        }
        //Console.WriteLine(path);
        if (result.Length % 8 > 0) result.Append(new string('0', 8 - result.Length % 8));
        //Console.WriteLine(result);
        for (int i = 0; i < result.Length / 8; i++)
        {
            int answer = 0;
            for (int k = i * 8; k < i * 8 + 8; k++)
            {
                if (result[k] == '1') answer += 1 << 7 - (k - i * 8);
            }
            Console.WriteLine(answer);

        }
    }
}