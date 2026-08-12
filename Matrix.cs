using System.Security.AccessControl;

class Matrix
{

    static void Main()
    {
        int[,] number ={{3,1,2},
                        {6,4,5},
                        {10,8,9}};
        for (int i = 0; i < number.GetLength(0); i++)
        {
            for (int j = 1; j < number.GetLength(1); j++)
            {
                if (number[i, j] < number[i, j - 1])
                {
                    (number[i, j], number[i, j - 1]) = (number[i, j - 1], number[i, j]);
                }


            }

        }
        foreach (var data in number)
        {
            Console.Write(data);
        }


    }
}
