/*
### 8. Longest Common Prefix

**Concepts:** String Matching

*/
using System.Runtime.Serialization;

class LongestCommonPrefix
{
    static void Main()
    {
        string[] name = ["geeksforgeeks", "geeks", "geek", "geezer"];
        Array.Sort(name);


        int i = 0;
        int j = 0;
        int first = name[0].Length - 1;
        int last = name[name.Length - 1].Length - 1;
        string common = " ";


        while (i < first && j < last)
        {
            if (i == j)
            {
                common += name[0][i];



            }
            i++;
            j++;
        }
        Console.WriteLine("common" + common);





    }
}

