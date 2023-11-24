public class Solution {
    public long solution(int a, int b) 
    {
        long answer = 0;
        int x;
        int y;
        if (a < b){
            x = a;
            y = b;
        }
        else{
            x = b;
            y = a;
        }
        for (int i = x; i <= y; i++)
        {
            answer += i;
            
        }
        
        return answer;
    }
}