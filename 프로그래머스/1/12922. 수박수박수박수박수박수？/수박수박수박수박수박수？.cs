public class Solution
{
    public string solution(int n)
    {
        string pattern = "수박";
        string answer = "";

        while (answer.Length < n)
        {
            answer += pattern;
        }

        return answer.Substring(0, n);
    }
}