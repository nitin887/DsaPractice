class BinarySearch
{
    //1 2 3 4 5
    public void Search(int[] arr, int target, int n)
    {
        int low = 0;
        int high = n - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                Console.WriteLine("Element at index:" + mid);
                break;

            }
            if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else if (arr[mid] > target)
            {
                high = mid - 1;

            }

        }




    }
    static void Main()
    {
        int[] number = { 1, 2, 3, 4, 5 };
        int n = number.Length;
        int target = 1;
        BinarySearch binarySearch = new BinarySearch();
        binarySearch.Search(number, target, n);
    }
}