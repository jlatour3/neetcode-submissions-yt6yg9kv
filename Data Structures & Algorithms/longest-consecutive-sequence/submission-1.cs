public class Solution {
    public int LongestConsecutive(int[] nums) {
        int longest = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            int prev = nums[i];
            int length = 1;
            for (int j = i + 1; j < nums.Length; j++)
            {
                int next = prev + 1;
                if (nums[j] == next)
                {
                   prev = nums[j];
                   length++;
                }
            }
            if (length > longest)
            {
                longest = length;
            }
        }
        return longest;
    }
}
