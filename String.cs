using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class String
{
    static void Main()
    {
        string name = "nitink";
        for (int i = name.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(name[i]);




        }
    }
}