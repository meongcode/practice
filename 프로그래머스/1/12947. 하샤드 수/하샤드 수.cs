public class Solution {
    public bool solution(int x) {
        int sum = 0;
        int Number = x;
        
        while (x > 0) 
        {
            sum += x % 10;
            x /= 10;
        }
        return Number % sum == 0;
    }
}