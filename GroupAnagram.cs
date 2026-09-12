/*
### 13. Group Anagrams
**Concepts:** Hashing
*/
string[] name = ["nniit", "mukesh", "ninit", "rajesh"];
Dictionary<string, int> anagram = new Dictionary<string, int>();
for (int i = 0; i < name.Length; i++)
{
    char[] names = name[i].ToCharArray();
    for (int j = 0; j < names.Length; j++)
    {
        Array.Sort(names);

    }
    name[i] = new string(names);
    Array.Sort(name);

}
for (int i = 1; i < name.Length; i++)
{
    if (!anagram.ContainsKey(name[i]))
    {
        anagram.Add(name[i], 1);
    }
    else
    {
        anagram[name[i]] += 1;
    }


}
foreach (var data in anagram)
{
    if (data.Value == 2)
    {
        Console.WriteLine("grouped anagram is:" + data.Key);
    }
}


