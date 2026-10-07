int[] number = { 1, 1, 1, 1, 2, 2, 3, 3, 3, 5, 5 };
int maxappearnace = 0;
int maxcount = 1;
Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
for (int i = 0; i < number.Length; i++)
{
    if (!keyValuePairs.ContainsKey(number[i]))
    {
        keyValuePairs.Add(number[i], maxcount); ;
    }
    else
    {
        keyValuePairs[number[i]] += 1;
    }

}
foreach (var data in keyValuePairs)
{
    int current = data.Value;
    if (current > maxcount)
    {
        maxcount = current;
        maxappearnace = data.Key;
    }

}
Console.WriteLine($"{maxappearnace} is appeared frequently with {maxcount}");