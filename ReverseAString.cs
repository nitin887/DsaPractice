/*
## Beginner

### 1. Reverse a String

**Concepts:** Two Pointers
*/
using System.Data;
using System.Globalization;

class ReverseAString
{
    static void Main()
    {
        string name = "nitink";
        char[] names = name.ToCharArray();
        int i = 0;
        int j = names.Length - 1;
        while (i < j)
        {

            (names[i], names[j]) = (names[j], names[i]);
            i++;
            j--;
        }
        for (int k = 0; k < names.Length; k++)
        {
            Console.WriteLine(names[k]);

        }



    }
}