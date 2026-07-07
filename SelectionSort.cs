class SelectionSort
{// 3 1 2 4 5
 //
    public static void SelectionSort1(int[] arr)
    {
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;



                }
            }
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);


        }
    }
    static void Main()
    {
        int[] arr1 = [2, 1, 4, 5];
        SelectionSort1(arr1);
        foreach (int arr2 in arr1)
        {
            Console.Write(arr2);
        }

    }

}