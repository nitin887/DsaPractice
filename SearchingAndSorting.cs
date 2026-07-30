using System.Data;
using System.Globalization;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;
/*






Interview-Level Problems
Median of Two Sorted Arrays
Find the median of two sorted arrays in O(log(min(n,m))) time.
Find Peak Element
Given an array, find a peak element using Binary Search.
Allocate Minimum Pages
Use Binary Search on the answer to minimize the maximum pages assigned.
Aggressive Cows
Place cows in stalls such that the minimum distance between any two cows is maximized.
Search in Infinite Sorted Array
Search an element in a conceptually infinite sorted array.
Find Square Root
Find the integer square root of a number using Binary Search.
Practice Input-Based Question

Question:
Given an array:

7 2 9 4 1 5
Sort it using Bubble Sort.
Search for 4 using Linear Search.
Search for 9 using Binary Search after sorting.

Expected sorted array:

1 2 4 5 7 9
*/
class Revision
{
    /*
    Inversion Count
    Count the number of inversions in an array efficiently.
    */
    public static int InversionCount = 0;

    static void Main()
    {
        int[] arr = [1, 4, 5, 7, 3, 2];
        int high = arr.Length - 1;
        int low = 0;
        MergeSort(arr, low, high);
        Console.WriteLine(InversionCount);

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
        for (i = 0; i < n1; i++)
        {
            L[i] = arr[i + low];

        }
        for (j = 0; j < n2; j++)
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
                InversionCount += n1 - i;
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