/*
### 6. Check Anagram

**Concepts:** Hashing, Sorting

*/
class Anagram
{
    static void Main()
    {
        string name = "nitin";
        string names = "nniit";
        char[] name1 = name.ToCharArray();
        char[] names1 = names.ToCharArray();
        for (int i = 0; i < name1.Length - 1; i++)
        {
            for (int j = 0; j < name1.Length - i - 1; j++)
            {
                if (name1[j] > name1[j + 1])
                {
                    (name1[j], name1[j + 1]) = (name1[j + 1], name1[j]);
                }

            }

        }
        for (int i = 0; i < names1.Length - 1; i++)
        {
            for (int j = 0; j < names1.Length - i - 1; j++)
            {
                if (names1[j] > names1[j + 1])
                {
                    (names1[j], names1[j + 1]) = (names1[j + 1], names1[j]);
                }

            }

        }
        if (new string(name1) == new string(names1))
        {
            Console.WriteLine("strings are anagram");
        }
        else
        {
            Console.WriteLine("string are not anagram");
        }


    }
}