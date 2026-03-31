public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> newNums = new HashSet<int>(nums);
        int longest = 0; 
        foreach (int num in nums) {
            
            if (!newNums.Contains(num-1)) {
                int length = 1; 
                while (newNums.Contains(num+length))
                    length++; 
                
                longest = Math.Max(length, longest);
            }

        }
        return longest; 
    }
}
