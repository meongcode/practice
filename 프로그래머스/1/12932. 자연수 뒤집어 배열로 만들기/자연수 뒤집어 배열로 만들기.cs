using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(long n)
    {
        // 숫자를 문자열로 변환
        string numberAsString = n.ToString();

        // 뒤집힌 숫자들을 저장할 리스트
        List<int> flippedList = new List<int>();

        // 숫자를 뒤에서부터 읽어서 리스트에 추가
        for (int i = numberAsString.Length - 1; i >= 0; i--)
        {
            flippedList.Add((int)Char.GetNumericValue(numberAsString[i]));
        }

        // 리스트를 배열로 변환하여 반환
        return flippedList.ToArray();
    }
}
