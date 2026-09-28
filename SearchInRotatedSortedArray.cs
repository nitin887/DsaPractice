int[] number = [4, 5, 6, 7, 0, 1, 2];
int target = 2;
int start = 0;
int end = number.Length - 1;
while (start < end)
{
    int mid = start + (end - start) / 2;


    if (number[mid] < target && number[mid - 1] > target)
    {
        end = mid - 1;
    }
    else if (number[end] == target)
    {
        Console.WriteLine("value is at:" + end);
        break;

    }
    if (number[mid] < target && number[mid + 1] < target)
    {
        start = mid + 1;
    }
    else if (number[start] == target)
    {
        Console.WriteLine("value is at:" + start);
        break;

    }
    if (number[mid] == target)
    {
        Console.WriteLine("value is at: " + mid);
        break;
    }

    start++;



}