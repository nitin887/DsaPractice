using System.ComponentModel.DataAnnotations;

class String
{
    static void Main()
    {
        string name = "nitin";
        char x = 't';
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == x)
            {
                Console.WriteLine("present at index:" + i);

            }

        }

    }

}
