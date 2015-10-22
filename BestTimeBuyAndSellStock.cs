/*

Say you have an array for which the ith element is the price of a given stock on day i.

If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), 

design an algorithm to find the maximum profit.

数组第i个元素表示货物第i天的价格，进行一次买入和一次卖出，使得收益最大

每次循环，取得到目前为止的最小价格(minimum stock price)和最大收益(maximum profit)

*/


public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        if (prices.Length <= 1) return maxProfit;
        
        int minStock = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            // if(prices[i] < minStock) minStock = prices[i];
            minStock = Math.Min(minStock, prices[i]);
            // if(prices[i] - minStock > maxProfit) maxProfit = prices[i] - minStock;
            maxProfit = Math.Max(maxProfit, prices[i] - minStock);
        }
        
        return maxProfit;   
    }
}
