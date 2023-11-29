using System;

public class Solution {
    public int[] solution(int[] arr, int divisor) 
    {
        
        int count = 0;  // divisor로 나누어지는 요소의 수를 세기 위한 카운터를 선언합니다.
        for (int i = 0; i < arr.Length; i++) // 배열을 순회하면서 divisor로 나누어지는 요소의 수를 카운트합니다.
        {
            if (arr[i] % divisor == 0) 
            {
                count++;
            }
        }
        
        if (count == 0) 
        {
            return new int[] { -1 }; // 나누어지는 요소가 없으면 -1만 포함한 배열을 반환합니다.
        }

        
        int[] result = new int[count]; // divisor로 나누어지는 요소를 저장할 배열을 생성합니다.
        int index = 0;

        for (int i = 0; i < arr.Length; i++) // 배열을 다시 순회하면서 divisor로 나누어지는 요소를 결과 배열에 저장합니다.
        {
            if (arr[i] % divisor == 0) 
            {
                result[index] = arr[i];
                index++;
            }
        }
        
        Array.Sort(result); // 결과 배열을 정렬합니다.

        return result;
    }
}