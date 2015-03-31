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
