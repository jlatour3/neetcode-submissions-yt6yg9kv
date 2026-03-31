public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagramGroups = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            int[] charCount = new int[26];
            foreach (char c in str)
            {
                charCount[c - 'a'] += 1;  
            }
            string key = string.Join(",", charCount);
            if (!anagramGroups.ContainsKey(key))
            {
                anagramGroups.Add(key, new List<string>());
            }
            anagramGroups[key].Add(str);
        }
        return anagramGroups.Values.ToList<List<string>>();
    }
}
