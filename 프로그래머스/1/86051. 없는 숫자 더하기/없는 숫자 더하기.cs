 
 	
using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;
        int result = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if(j == numbers[i])
                    result = j;
            }
            answer -= result;
        }
        
        return answer;
    }
}