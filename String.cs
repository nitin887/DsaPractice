using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class String
{
    static void Main()
    {
        string name = "nitink";
        char[] name1 = name.ToCharArray();
        int d = 2;

        for (int i = 0; i < d; i++)
        {
            char first = name1[0];
            for (int j = 0; j < name1.Length - 1; j++)
            {
                name1[j] = name1[j + 1];


            }
            name1[name1.Length - 1] = first;

        }


        for (int i = 0; i < name1.Length; i++)
        {
            Console.WriteLine(name1[i]);

        }





    }
}
