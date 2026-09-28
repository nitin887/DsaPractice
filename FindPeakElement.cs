int[] number = { 1, 20, 4, 1, 0 };
int start = 1;
int end = number.Length - 1;

while (start < end)
{
    int mid = start - 1 + (end - start) / 2;
    if (number[mid] > number[mid + 1] && number[mid] > number[mid - 1])
    {
        int peakelement = number[mid];
        Console.WriteLine("peak element is:" + peakelement);
        break;



    }
    if (number[mid] < number[mid + 1] && number[mid] > number[mid - 1])
    {
        start = mid + 1;
    }
    else if (number[mid] > number[mid + 1] && number[mid] < number[mid - 1])
    {
        end = mid - 1;
    }



}
//finding multiple peak
// for (int i = 1; i < number.Length; i++)
// {
//     if (number[i] > number[i - 1] && number[i] > number[i + 1])
//     {
//         int peakelement = number[i];
//         Console.WriteLine("peak element are:" + peakelement);


//     }

// }