using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        Stack<int> stack = new Stack<int>();
        
        while (n > 0) {
            stack.Push(n % 3);
            n /= 3;
        }
        
        int answer = 0;
        int temp = 1;
        while (stack.Count > 0) {
            answer += stack.Pop() * temp;
            temp *= 3;
        }
        
        return answer;
    }
}