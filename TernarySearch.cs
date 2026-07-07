using System.Runtime;

class TernarySearch
{// 1 2 4 5 6
 //  0 1 2 3 4
    public void Searching(int[] arr, int target, int n)
    {
        int low = 0;
        int high = n - 1;
        while (low <= high)
        {
            int mid1 = low + high - low / 3;
            int mid2 = high - high - low / 3;
            if (arr[mid1] == target)
            {
                Console.WriteLine("Value is at index:" + mid1);
                break;

            }
            if (arr[mid2] == target)
            {
                Console.WriteLine("Value is at index:" + mid2);
                break;

            }

            if (target < arr[mid1])
            {
                high = mid1 - 1;
            }

            else if (target > arr[mid2])
            {
                low = mid2 + 1;

            }
            else
            {
                low = mid1 + 1;
                high = mid2 - 1;
            }


        }

    }
    static void Main()
    {
        int[] number = { 1, 2, 3, 4, 5 };
        int n = number.Length;
        int target = 5;
        TernarySearch ternarySearch = new TernarySearch();
        ternarySearch.Searching(number, target, n);

    }
}