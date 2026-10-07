string fruit = "banana";
Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
for (int i = 0; i < fruit.Length; i++)
{
    int count = 0;
    if (!keyValuePairs.ContainsKey(fruit[i]))
    {
        count++;
        keyValuePairs.Add(fruit[i], count);
    }
    else
    {
        keyValuePairs[fruit[i]] += 1;
    }

}
foreach (var data in keyValuePairs)
{
    Console.WriteLine($"{data.Key}-{data.Value}");
}