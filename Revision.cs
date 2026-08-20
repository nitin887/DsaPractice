
using System.Globalization;

class Revision
{
    /*
  ### 24. Kadane's Algorithm (Maximum Subarray Sum)

  */
    static void Main()
    {
        int[] number = [1, 2, 3, 2, 2, 6];
        int currentSum = number[0];
        int maxSum = number[0];

        for (int i = 1; i < number.Length; i++)
        {
            // Either start a new subarray at number[i] or extend the current subarray
            currentSum = Math.Max(number[i], currentSum + number[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        Console.WriteLine("max sum:" + maxSum);
    }
}
