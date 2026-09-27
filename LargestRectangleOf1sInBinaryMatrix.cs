int[,] matrix = {
    {1, 1, 1},
    {0, 0, 0},
    {1, 1, 0},
    {1, 1, 0}
};

int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

// Simpler: reduce it to "largest rectangle in a histogram" (a stack problem).
// heights[j] = vertical run of consecutive 1s in column j up to the current row.
// Every row forms a histogram, so reuse the classic monotonic-stack solve.

int[] heights = new int[cols];
int maxarea = 0;

for (int i = 0; i < rows; i++)
{
    // 1) Build this row's histogram
    for (int j = 0; j < cols; j++)
        heights[j] = matrix[i, j] == 1 ? heights[j] + 1 : 0;

    // 2) Largest rectangle inside that histogram - O(cols)
    int[] stack = new int[cols + 1]; // indexes of bars, increasing height
    int top = -1;
    for (int j = 0; j <= cols; j++)
    {
        int h = j == cols ? 0 : heights[j]; // sentinel 0 flushes leftover bars
        while (top >= 0 && h < heights[stack[top]])
        {
            int height = heights[stack[top--]];   // popped bar is the tallest usable here
            int width  = top < 0 ? j : j - stack[top] - 1;
            maxarea = Math.Max(maxarea, height * width);
        }
        stack[++top] = j;
    }
}

Console.WriteLine("max area:" + maxarea);

