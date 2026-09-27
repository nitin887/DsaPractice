/*
### Spiral Matrix Traversal

**Concepts:** Matrix Traversal
*/
int[,] number =
{
 {1,2},
 {4,5},
 {3,4},
 {10,11}

};
int left = 0;
int right = number.GetLength(1) - 1;
int top = 0;
int bottom = number.GetLength(0) - 1;
while (left <= right && top <= bottom)
{
    for (int i = left; i <= right; i++)
    {
        Console.Write(number[left, i]);

    }
    for (int i = top + 1; i <= bottom; i++)
    {


        Console.Write(number[i, right]);
    }

    for (int i = right - 1; i >= left; i--)
    {

        Console.Write(number[bottom, i]);

    }
    if (left < right)
    {
        for (int i = bottom - 1; i > top; i--)
        {
            Console.Write(number[i, top]);
        }
    }
    left++;
    right--;
    bottom--;
    top++;
}




