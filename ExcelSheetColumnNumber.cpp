class Solution {
public:
    int titleToNumber(string s) {
        if(s.size() == 0)
            return 0;
    
        int size = s.size();
        int num = 0;
        for(int i = 0; i < size; i++){
            num += (s[i] - 64) * pow(26, size-1-i);
            // num = num * 26 + s[i] - 64; // without inlucde <cmath> and using pow()
        }
        
        return num;
        }
};
