int[] number = { 2, 1, 0, 2, 1, 0 };
int start = 0;
int mid = 0;
int end = number.Length - 1;
while (mid <= end)
{
    if (number[mid] == 0)
    {
        (number[start], number[mid]) = (number[mid], number[start]);
        start++;
        mid++;
    }
    else if (number[mid] == 1)
    {
        mid++;
    }
    else
    {
        (number[mid], number[end]) = (number[end], number[mid]);
        end--;

    }




}


foreach (var data in number)
{
    Console.WriteLine(data);
}