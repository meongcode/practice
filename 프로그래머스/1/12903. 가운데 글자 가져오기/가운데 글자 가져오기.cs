using System;

public class Solution
{
    public string solution(string s) 
    {
        int length = s.Length; 
        int middle = length / 2;

        if (length % 2 == 0) 
        {
            return s.Substring(middle - 1, 2);
        } 
        
        else
        {
            return s.Substring(middle, 1);
        }
    }
}