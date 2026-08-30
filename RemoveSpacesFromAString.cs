/*
### 5. Remove Spaces from String

**Concepts:** String Manipulation

---
*/
class RemoveSpacesFromAString
{
    static void Main()
    {
        string names = "    nitin  ";
        List<char> name = new List<char>();
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] != ' ')
            {
                name.Add(names[i]);

            }


        }
        names = new string(name.ToArray());
        Console.WriteLine(names);
    }
}