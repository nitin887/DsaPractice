class InsertionSort
{
    public static void InsertionSort1(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;


        }

    }

    static void Main()
    {
        int[] arr1 = [2, 1, 4, 5];
        InsertionSort1(arr1);
        foreach (int arr2 in arr1)
        {
            Console.Write(arr2);
        }

    }
}