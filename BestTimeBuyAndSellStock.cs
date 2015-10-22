/*

Say you have an array for which the ith element is the price of a given stock on day i.

If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), 

design an algorithm to find the maximum profit.

数组第i个元素表示货物第i天的价格，进行一次买入和一次卖出，使得收益做大



*/


public class Solution {
    public int MaxProfit(int[] prices) {
        int ret = 0;
        if (prices.Length <= 1) return ret;
        
        int min = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            ret = Math.Max(ret, prices[i] - min);
        }
        
        return ret;   
    }
}
