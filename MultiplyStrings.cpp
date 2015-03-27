class Solution {
public:
    string multiply(string num1, string num2) {
        if (num1.size() <= 0 || num2.size() <= 0) 
            return "";
    
        int size1 = num1.length();
        int size2 = num2.length();
        int size3 = size1 + size2;
        string sum(size3, '0');
        
        for(int j = size2 -1; j >= 0; j--)
        {
            int b = num2[j] - '0';
            // cout << "b = " << b << endl;
            for(int i = size1 -1; i >= 0; i--)
            {
                int a = num1[i] - '0';
                // cout << "a = " << a << endl;
                int x = (size3 - 1) - (size2 - j - 1) - (size1 - i - 1);    // 积的位数
                // cout << "x = " << x << endl;
                int carry = sum[x] - '0' + a * b;   // 逐位相乘和相应的乘积位相加
                // cout << "carry = " << carry << endl; 
                if(carry > 9)
                {
                    sum[x] = '0' + (carry % 10);
                    sum[x - 1] = '0' + (sum[x - 1] - '0' + carry / 10);
                }
                else
                {
                    sum[x] = '0' + carry;
                }
            }
            // cout << endl;
        }
        
        if(sum[0] == '0' && sum[1] == '0')
            return "0";
        
        if(sum[0] == '0')
            return &sum[1];
            
        return sum;
    }
};
