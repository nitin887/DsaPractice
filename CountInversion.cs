class CountInversion
{

    static void Main()
    {
        int[] arr = { 8, 4, 2, 1 };
        int low = 0;
        int high = arr.Length - 1;
        int inversion = 0;
        MergeSort(arr, low, high, ref inversion);
        Console.WriteLine(inversion);

    }
    static void MergeSort(int[] arr, int low, int high, ref int inversion)
    {
        if (low >= high) // base case: single element, no inversions
            return;

        int mid = low + (high - low) / 2;
        MergeSort(arr, low, mid, ref inversion);
        MergeSort(arr, mid + 1, high, ref inversion);
        Merge(arr, low, mid, high, ref inversion);



    }
    static void Merge(int[] arr, int low, int mid, int high, ref int inversion)
    {
        int n1 = mid - low + 1;
        int n2 = high - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i;
        int j;
        for (i = 0; i < n1; i++)
        {
            L[i] = arr[low + i];

        }
        for (j = 0; j < n2; j++)
        {
            R[j] = arr[mid + 1 + j];

        }
        i = 0;
        j = 0;
        int K = low;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[K] = L[i];

                i++;
            }
            else
            {
                arr[K] = R[j];
                // R[j] is smaller than every not-yet-copied left element
                // L[i]..L[n1-1], so it forms (n1 - i) inversions with them.
                inversion += (n1 - i);
                j++;


            }
            K++;



        }
        while (i < n1)
        {
            arr[K] = L[i]; // no new inversions here: already counted above
            i++;
            K++;
        }
        while (j < n2)
        {
            arr[K] = R[j];
            j++;
            K++;


        }




    }


}