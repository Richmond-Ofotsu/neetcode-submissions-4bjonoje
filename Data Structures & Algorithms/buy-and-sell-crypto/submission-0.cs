public class Solution {
    public int MaxProfit(int[] prices) {
        int cheapest = prices[0];
        int bestProfit = 0;

        foreach (int price in prices)
        {
            if (price < cheapest)
                {
                    cheapest = price;
                }
            int profit = price - cheapest;

            if (profit > bestProfit)
                {
                    bestProfit = profit;
                }
        }

        return bestProfit;
    }
}
