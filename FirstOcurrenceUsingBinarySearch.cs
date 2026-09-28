using System.Runtime.CompilerServices;

int[] number = { 0, 1, 2, 2, 3, 4 };
int target = 2;
int low = 0;
int high = number.Length - 1;
int currentindex = 0;
while (low < high)
{
    int mid = low + (high - low) / 2;
    if (number[mid] == target)
    {
        currentindex = mid;



    }
    else if (number[mid] == target && number[mid - 1] == target)
    {
        high = mid - 1;
        currentindex = high;

    }
    high--;







}
Console.WriteLine("current index:" + currentindex);
