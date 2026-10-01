using System.Globalization;
using System.Security.Cryptography;

class Revision1
{
    static void Main()
    {
        int[] arr = { 9, 3, 4, 2, 5 };
        int low = 0;
        int high = arr.Length;
        QuickSort(arr, low, high - 1);
        foreach (var data in arr)
        {
            Console.WriteLine(data);
        }

    }
    static void QuickSort(int[] arr, int low, int high)
    {
        while (low < high)
        {
            int pivot = Pivot(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
            low++;
        }
    }
    static int Pivot(int[] arr, int low, int high)
    {
        int random = arr[RandomNumberGenerator.GetInt32(low, high)];
        (random, high) = (high, random);
        int pivot = arr[high];

        int i = low - 1;
        for (int j = low; j < high; j++)
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
//     //merge sort
//     static void Main()
//     {
//         int[] array = { 3, 9, 4, 2, 10 };
//         int low = 0;
//         int high = array.Length - 1;
//         MergeSort(array, low, high);
//         foreach (var data in array)
//         {
//             Console.WriteLine(data);
//         }

//     }
//     static void MergeSort(int[] array, int low, int high)
//     {
//         while (low < high)
//         {
//             int mid = low + (high - low) / 2;
//             MergeSort(array, low, mid);
//             MergeSort(array, mid + 1, high);
//             Merge(array, low, mid, high);
//             low++;
//         }

//     }
//     static void Merge(int[] array, int low, int mid, int high)
//     {
//         int n1 = mid - low + 1;
//         int n2 = high - mid;
//         int[] L = new int[n1];
//         int[] R = new int[n2];
//         int i;
//         int j;
//         for (i = 0; i < n1; ++i)
//         {
//             L[i] = array[low + i];

//         }
//         for (j = 0; j < n2; ++j)
//         {
//             R[j] = array[mid + 1 + j];
//         }
//         i = 0;
//         j = 0;
//         int k = low;
//         while (i < n1 && j < n2)
//         {
//             if (L[i] <= R[j])
//             {
//                 array[k] = L[i];
//                 i++;
//             }
//             else
//             {
//                 array[k] = R[j];
//                 j++;

//             }
//             k++;
//         }
//         while (i < n1)
//         {
//             array[k] = L[i];
//             i++;
//             k++;
//         }
//         while (j < n2)
//         {
//             array[k] = R[j];
//             j++;
//             k++;
//         }
//     }
// }

//insetion sort
// bool issorting = false;
// for (int i = 1; i < number.Length; i++)
// {
//     int key = number[i];
//     int j = i - 1;
//     while (j >= 0 && number[j] > key)
//     {
//         number[j + 1] = number[j];
//         issorting = true;
//         j--;
//     }
//     if (!issorting)
//     {
//         Console.WriteLine("array already sorted");
//         break;

//     }
//     number[j + 1] = key;

// }


//selection sort
// for (int i = 0; i < number.Length - 1; i++)
// {
//     int minindex = i;
//     for (int j = i + 1; j < number.Length; j++)
//     {
//         if (number[j] < number[minindex])
//         {
//             minindex = j;
//             issminimum = true;
//         }

//     }
//     if (!issminimum)
//     {
//         Console.WriteLine("program ended");
//         break;
//     }
//     (number[i], number[minindex]) = (number[minindex], number[i]);


// }

//buuble sort
// for (int i = 0; i < number.Length - 1; i++)
// {
//     for (int j = 0; j < number.Length - i - 1; j++)
//     {
//         if (number[j] > number[j + 1])
//         {

//             int temp = number[j];
//             number[j] = number[j + 1];
//             number[j + 1] = temp;
//             isswapped = true;
//         }



//     }
//     if (!isswapped)
//     {
//         Console.WriteLine("program has ended");
//         break;
//     }

// }
