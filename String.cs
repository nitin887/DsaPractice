using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class String
{
    static void Main()
    {
        string name = "nitin1";
        string name1 = "nitin0";
        bool issame = false;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == name1[i])
            {
                issame = true;
            }
            else
            {
                issame = false;
                break;
            }

        }
        if (issame)
        {
            Console.WriteLine("string are same");
        }
        else
        {
            Console.WriteLine("strings are not same");
        }
    }

}
