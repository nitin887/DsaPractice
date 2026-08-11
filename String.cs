using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class String
{
    static void Main()
    {
        string name = "nitin0";
        char[] names = name.ToCharArray();

        for (int i = 1; i <= names.Length - 1; i++)
        {
            names[i] = name[i - 1];


        }
        names[0] = 'x';
        foreach (char x in names)
        {
            Console.WriteLine(x);
        }

    }

}
