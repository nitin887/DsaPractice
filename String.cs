using System.ComponentModel.DataAnnotations;

class String
{
    static void Main()
    {
        string name = "nitin";
        string x = "tii";
        bool isfound = false;

        for (int i = 0; i < x.Length; i++)
        {
            if (name[i] == x[i])
            {

                isfound = true;


            }
            else
            {
                isfound = false;
            }


        }
        if (!isfound)
        {
            Console.WriteLine("do not exist");
        }
        else
        {
            Console.WriteLine("substring exist");
        }

    }

}
