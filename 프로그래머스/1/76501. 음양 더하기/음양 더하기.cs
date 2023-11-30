using System;

public class Solution 
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            answer = signs[i] ? answer+absolutes[i] : answer-absolutes[i];
        }
        return answer;
    }
} //풀기 어려워서 다른 분 코드 참고하여 공부하려 합니다.