// Search in a sorted matrix using Binary Search.
// The matrix behaves like ONE big sorted array:
//   1) every row is sorted in ascending order
//   2) the first element of row i+1 is GREATER than the last element of row i
//      (5 > 3 and 9 > 7 in the matrix below)
//
// So we can binary search a virtual array of size rows * cols.
// A linear mid index is mapped back to a cell with:
//     row = mid / cols      (integer division)
//     col = mid % cols      (remainder)
//
// Time complexity : O(log(rows * cols))
// Space complexity: O(1)

class SearchInASortedMatrix
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 5, 6, 7 },
            { 9, 10, 11 },
        };
        int target = 10;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int left = 0;
        int right = rows * cols - 1;
        bool found = false;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target)
            {
                Console.WriteLine($"value is at: {mid / cols} row and {mid % cols} column");
                found = true;
                break;
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (!found)
        {
            Console.WriteLine("value not found");
        }
    }
}