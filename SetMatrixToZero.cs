using System.Globalization;

int[,] matrix ={{1,2,3},
               { 4, 2, 0 },
               { 3,2,9} };
int rowloc = 0;
int coloc = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == 0)
        {
            rowloc = i;
            coloc = j;

        }






    }


}
Console.WriteLine($"value is at:{rowloc} row and  {coloc} colc");
for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        if (j == coloc)
        {
            matrix[i, j] = matrix[rowloc, coloc];

        }
        else if (i == rowloc)
        {
            matrix[i, j] = matrix[rowloc, coloc];
        }



    }

}
foreach (var data in matrix)
{
    Console.Write(data);
}
