/*
### 4. Find Frequency of Characters

**Concepts:** Hashing
*/
class FrequencyOfCharacter
{
    static void Main()
    {
        string name = "nitin";
        int k = 1;
        Dictionary<char, int> names = new Dictionary<char, int>();
        for (int i = 0; i < name.Length; i++)
        {
            if (!names.ContainsKey(name[i]))
            {
                names.Add(name[i], k);

            }
            else
            {
                names[name[i]] += 1;
            }

        }
        foreach (var data in names)
        {
            Console.WriteLine($"{data.Key}-{data.Value}");
        }
    }
}