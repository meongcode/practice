public class Solution {
    public int[] solution(int n, int m) 
    {
        int GCD = 1;
        int LCM = 1;
        
        int divisor = 2;
        while (divisor <= n) 
        {
            if (n % divisor == 0 && m % divisor == 0) 
            {
                n /= divisor;
                m /= divisor;
                GCD *= divisor;
            }
            else divisor++;
        }
        LCM = GCD * n * m;
        return new int[] {GCD, LCM};
    }
} 