using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
/*
Reversal algorithm
*/
class String
{
    static string Rotate(string name, int d)
    {
        int n = name.Length;
        d %= n;
        char[] temp = name.ToCharArray();
        Reverse(temp, 0, d - 1);
        Reverse(temp, d, n - 1);
        Reverse(temp, 0, n - 1);

        return new string(temp);

    }

    static void Reverse(char[] temp, int start, int end)
    {
        while (start < end)
        {
            (temp[start], temp[end]) = (temp[end], temp[start]);
            start++;
            end--;
        }
    }

    static void Main()
    {
        string name = "nitink";
        int d = 2;
        Console.WriteLine(Rotate(name, d));











    }
}
