using System.Configuration.Assemblies;
using System.Globalization;

class MergeSorts
{
    static void Main()
    {
        int[] arr = [6, 3, 1, 8, 7];
        int n = arr.Length - 1;
        MergeSort(arr, 0, n);
        foreach (int x in arr)
        {
            Console.Write(x);
        }

    }
    static void MergeSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int mid = low + (high - low) / 2;
            MergeSort(arr, low, mid);
            MergeSort(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }


    }
    static void Merge(int[] arr, int low, int mid, int high)
    {
        int n1 = mid - low + 1;
        int n2 = high - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
        {
            L[i] = arr[low + i];

        }
        for (j = 0; j < n2; ++j)
        {
            R[j] = arr[mid + 1 + j];

        }
        i = 0;
        j = 0;
        int k = low;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;


            }
            else
            {
                arr[k] = R[j];
                j++;


            }
            k++;

        }
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;

        }


    }
}