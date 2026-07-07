class QuickSorts
{
    static void Main()
    {
        int[] arr = [5, 1, 6, 4, 2];
        int n = arr.Length;
        Quicksort(arr, 0, n - 1);
        foreach (int data in arr)
        {
            Console.Write(data);
        }





    }
    static void Quicksort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Pivot(arr, low, high);
            Quicksort(arr, low, pivot - 1);
            Quicksort(arr, pivot + 1, high);
        }

    }
    static int Pivot(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;


    }
}