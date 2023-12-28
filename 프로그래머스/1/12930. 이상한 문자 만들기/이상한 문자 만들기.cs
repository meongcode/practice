public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] strings = s.Split(' ');
        for (int i = 0; i < strings.Length; i++) {
            for (int j = 0; j < strings[i].Length; j++) {
                answer += j % 2 == 0 ? strings[i][j].ToString().ToUpper() : strings[i][j].ToString().ToLower();
            }
            if (i != strings.Length - 1) answer += " ";
        }
        return answer;
    }
}