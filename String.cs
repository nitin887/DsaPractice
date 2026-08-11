using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class String
{
    static void Main()
    {
        string name = "nitin0";
        char[] names = name.ToCharArray();
        int n = names.Length;

        for (int i = 0; i < n - 1; i++)
        {
            names[i] = name[i + 1];



        }
        for (int i = 0; i < n - 1; i++)
        {

            Console.WriteLine(names[i]);
        }

    }

}
