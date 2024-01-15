public class Solution 
{
    public string solution(string s, int n)
    {
        string answer = "";
        foreach (var c in s)
        {
            if (c != ' ')
            {
                if (char.IsUpper(c))  answer += (char)((c - 'A' + n) % 26 + 'A');
                else if (char.IsLower(c))  answer += (char)((c - 'a' + n) % 26 + 'a');
            }
            else    answer += ' ';
        }
        return answer;
    }
}