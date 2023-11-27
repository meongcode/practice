public class Solution 
{
    public long solution(long num) 
    {
        long answer = 0;
        
        for(int i = 0; i <= 500; i++)
        {
            
            if(num != 1)
            {
                if(num % 2 == 0)
                {
                    num = num / 2;
                }
                else if(num % 2 != 0)
                {
                    num = (num*3) + 1;
                }
                
            }
            else
            {
                answer = i;
                return answer;
            }
        }
        return -1;
    }
}