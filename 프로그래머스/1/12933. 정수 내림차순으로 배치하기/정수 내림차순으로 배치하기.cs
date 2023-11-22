using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public long solution(long n) 
    {
        char[] s = n.ToString().ToCharArray();
        Array.Sort(s);
        Array.Reverse(s);
        long answer = long.Parse(s);
        return answer;
    }
}