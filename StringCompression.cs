/*
### 9. String Compression

**Concepts:** Run-Length Encoding

*/
using System.Runtime.ConstrainedExecution;
using System.Text.Unicode;

class StringCompression
{
    static void Main()
    {
        string name = "abbbbcccc";
        int occurences = 1;
        Dictionary<char, int> candidate = new Dictionary<char, int>();
        for (int i = 0; i < name.Length; i++)
        {
            if (!candidate.ContainsKey(name[i]))
            {

                candidate.Add(name[i], occurences);
            }
            else
            {
                candidate[name[i]] += 1;
            }
        }
        foreach (var data in candidate)
        {
            if (data.Value > 1)
            {
                Console.Write($"{data.Key}{data.Value}");
            }
            else
            {
                Console.Write($"{data.Key}");
            }
        }





    }
}