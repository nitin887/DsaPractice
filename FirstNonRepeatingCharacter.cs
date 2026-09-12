/*
### 7. First Non-Repeating Character

**Concepts:** HashMap

*/
class FirstNonRepeatingCharacter
{
    static void Main()
    {
        string name = "nitin";
        Dictionary<char, int> occurences = new Dictionary<char, int>();
        for (int i = 0; i < name.Length; i++)
        {
            if (!occurences.ContainsKey(name[i]))
            {
                occurences.Add(name[i], 1);
            }
            else
            {
                occurences[name[i]] += 1;
            }

        }
        foreach (var data in occurences)
        {
            if (data.Value == 1)
            {
                Console.WriteLine("first non repeating character is:" + data.Key);
                break;
            }
        }
    }
}