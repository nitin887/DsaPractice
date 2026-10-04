using System;

class FindTwoNonRepeating
{
    static void FindNumbers(int[] arr)
    {
        int xorSum = 0;


        foreach (int num in arr)
        {
            xorSum ^= num;
        }


        int setBit = xorSum & (-xorSum);

        int num1 = 0;
        int num2 = 0;


        foreach (int num in arr)
        {
            if ((num & setBit) != 0)
            {
                num1 ^= num;
            }
            else
            {
                num2 ^= num;
            }
        }

        Console.WriteLine($"The two non-repeating numbers are: {num1} and {num2}");
    }

    static void Main()
    {
        int[] arr = { 2, 3, 7, 9, 11, 2, 3, 11 };
        FindNumbers(arr);
    }
}
