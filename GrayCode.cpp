class Solution {
public:
    vector<int> grayCode(int n) {
        vector<int> ret; 
    
        for (unsigned int i = 0; i < (1 << n); i++)
        {
            ret.push_back((i >> 1) ^ i);
        }
        return ret;
    }
};
