int[] number = { 100, 4, 200, 1, 3, 2, 6 };
Array.Sort(number);
int maxlength = 0;
int left = 0;

foreach (var data in number)
{
    Console.WriteLine(data);
}
for (int right = 0; right < number.Length - 1; right++)
{
    if (number[right + 1] - number[right] != 1)
    {
        maxlength = Math.Max(maxlength, right - left + 1);

    }


}
Console.WriteLine(maxlength);

