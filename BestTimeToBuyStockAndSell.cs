/*
### 11. Best Time to Buy and Sell Stock

**Concepts:** Prefix Minimum

*/
using System.Globalization;

class BestTimeToBuyStockAndSell
{
    static void Main()
    {
        int[] stocks = [3, 1, 4, 5, 7, 1];
        int minPrice = 3;
        int maxPrice = 0;

        int profit = 0;
        for (int i = 1; i < stocks.Length; i++)
        {
            int newPrice = stocks[i];

            int newProfit = newPrice - minPrice;
            if (newProfit > profit)
            {
                profit = newProfit;
            }
            if (newPrice < minPrice)
            {
                minPrice = newPrice;
            }
            else if (newPrice > minPrice)
            {
                maxPrice = newPrice;
            }

        }
        Console.WriteLine("best time to buy stock: {0} and sell:{1} with profit :{2}", minPrice, maxPrice, profit);

    }
}