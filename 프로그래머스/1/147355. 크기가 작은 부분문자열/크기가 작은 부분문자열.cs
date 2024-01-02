using System;

public class Solution {
    public int solution(string t, string p) {
        long criteria = long.Parse(p);
        int count = 0;
        for (int i = 0; i <= t.Length - p.Length; i++) {
            if (long.Parse(t.Substring(i, p.Length)) <= criteria) count++;
        }
        return count;
    }
}