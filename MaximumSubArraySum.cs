/*
### 10. Kadane's Algorithm

**Concepts:** Maximum Subarray Sum

*/
using System.Runtime.CompilerServices;

class MaximumSubArraySum
{
    static void Main()
    {
        int[] number = [3, -1, 6, -2, 4];
        int maxsum = 3;
        for (int i = 1; i <= number.Length - 1; i++)
        {
            maxsum += number[i];

        }
        Console.WriteLine("MAX Sum is:" + maxsum);

    }
}