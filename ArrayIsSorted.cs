/*
### 3. Check if Array is Sorted

**Concepts:** Linear Scan

*/
using System.Runtime.CompilerServices;

class ArrayIsSorted
{
    static void Main()
    {
        int[] number = [2, 3, 1, 5, 6];
        bool isSorted = false;
        for (int i = 0; i < number.Length - 1; i++)
        {
            if (number[i] < number[i + 1])
            {
                isSorted = true;
            }
            else
            {
                isSorted = false;
                break;
            }

        }
        if (isSorted)
        {
            Console.WriteLine("array is sorted");
        }
        else
        {
            Console.WriteLine("array is not sorted");
        }

    }
}