class Solution {
public:
    string convertToTitle(int n) {
        string s;
        
        while(n > 0)
        {
            s.insert( s.begin(), (n - 1)  % 26 + 'A' );
            n = (n - 1) / 26;
        }
    
        return s;  
    }
};
