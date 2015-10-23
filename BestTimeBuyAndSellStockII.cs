/*

Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. You may complete as many transactions as you like 
(ie, buy one and sell one share of the stock multiple times). 
However, you may not engage in multiple transactions at the same time 
(ie, you must sell the stock before you buy again).

数组第i个元素表示货物第i天的价格，进行多次买入和卖出，使得收益最大

不买入不能卖出，当天卖出不能当天买入，买入则必须卖出（买入卖出须成对出现且不能在同一天进行）

寻找数列中的所有递增子数列，各个字数列最右减最左得收益，再求收益和

如果当前元素比下一个元素小，则总收益增加二者的差

*/


public class Solution {
    public int MaxProfit(int[] prices) {
        
        int profit = 0;
        if (prices.Length < 2) return profit;
        
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i + 1] - prices[i] > 0)
                profit += prices[i + 1] - prices[i];
        }
        
        return profit;    
    }
}
