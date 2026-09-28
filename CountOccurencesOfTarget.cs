int[] number = { 1, 1, 4, 5, 7, 7, 1 };
int target = 7;
int count = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] == target)
    {
        count++;

    }

}
Console.WriteLine("no of occurences:" + count);