/*
### 3. Find Sum of All Elements

**Concepts:** Nested Loops

*/
int[,] matrix = { { 1, 2, 3 }, { 2, 3, 4 }, { 4, 5, 6 } };
int sum = 0;
foreach (var result in matrix)
{
    sum += result;

}
Console.WriteLine(sum);