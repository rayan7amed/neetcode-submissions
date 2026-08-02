public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxprofit = 0;

        int i = 0, j = 1;
        while (j < prices.Length)
        {
            int profit = prices[j] - prices[i];

            if (profit > maxprofit)
                maxprofit = profit;

            if (prices[i] > prices[j])
                i = j;

            j++;
        }

        return maxprofit;
    }
}