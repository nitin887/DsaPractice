string name = "aabbcde";
Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
for (int i = 0; i < name.Length; i++)
{
    if (!keyValuePairs.ContainsKey(name[i]))
    {

        keyValuePairs.Add(name[i], 1);
    }
    else
    {
        keyValuePairs[name[i]] += 1;
    }

}
foreach (var data in keyValuePairs)
{
    if (data.Value == 1)
    {
        Console.WriteLine("First Non Occuring char is:" + data.Key);
        break;

    }
}