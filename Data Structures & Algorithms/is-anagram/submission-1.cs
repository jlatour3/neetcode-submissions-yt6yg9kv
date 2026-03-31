public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        // Keep track of letters in s, compare them to t 
        // O(n) + O(n)
        int[] alphabetCount = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            char curr = s[i];
            alphabetCount[curr - 'a'] += 1;
        }
        for (int j = 0; j < t.Length; j++)
        {
            char curr = t[j];
            alphabetCount[curr - 'a'] -= 1;
            if (alphabetCount[curr - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}