int[] number = { 1, 1, 4, 5, 7, 7, 1 };
int target = 7;
int firstIndex = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] == target)
    {
        firstIndex = i;
        break;
    }
}
Console.WriteLine("first index of occurences:" + firstIndex);