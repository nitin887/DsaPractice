using System.ComponentModel.DataAnnotations;

class StringAndMatrix
{
    static void Main()
    {
        string name = "nitin";
        int Length = 0;
        foreach (char x in name)
        {
            Length++;
        }
        Console.WriteLine(Length);

    }

}
