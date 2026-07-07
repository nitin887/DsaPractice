class BubbleSort
{
    public static void BubbleSort1(int[] arr)
    {
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;


                }




            }

        }

    }
    static void Main()
    {
        int[] arr1 = [2, 1, 4, 5];
        BubbleSort1(arr1);
        foreach (int arr2 in arr1)
        {
            Console.Write(arr2);
        }

    }
}