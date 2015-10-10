/*

Given a set of distinct integers, S, return all possible subsets.

Note:
Elements in a subset must be in non-descending order.
The solution set must not contain duplicate subsets.
For example,
If S = [1,2,3], a solution is:

[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
]

求合集的子集（包括空集和本省），二维向量

合集元素个数为N，则子集个数为1 << N - 1 = 2^N
N=3时, 子集个数2^N = 8个，子集 = {{}, {1}, {2}, {3}, {1,2}, {1,3}, {2,3}, {1,2,3}}
其二进制表示 {{0,0,0}, {1,0,0}, {0,1,0}, {0,0,1}, {1,1,0}, {1,0,1}, {0,1,1}, {1,1,1}}，1代表集合中有该元素，0代表没有
遍历所有子集的二进制表示，查看哪一位是1

*/


class Solution {
public:
    vector<vector<int>> subsets(vector<int> &S)
    {
        // 排序，#include <algorithm>
        sort(S.begin(), S.end());
        vector<vector<int>> ret;
        
        // 遍历所有子集，0 ~ 2^N(1 << S.size())
        for(int i = 0; i < (1 << S.size()); i++)
        {
            vector<int> v;
            int temp = i;
            
            // 查看子集中每一位是否为1，若为1则包含该元素，否则不包含
            for(size_t j = 0; j < S.size(); j++)
            {
                if(temp & 1)
                {
                    v.push_back(S[j]);
                }
                temp >>= 1;
            }
            ret.push_back(v);
        }
        
        return ret;
    }
};
