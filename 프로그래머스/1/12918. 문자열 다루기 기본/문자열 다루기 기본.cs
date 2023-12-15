public class Solution {
    public bool solution(string s) {
        if (s.Length != 4 && s.Length != 6) return false;
        if (long.TryParse(s, out long temp)) return true;
        return false;
    }
}