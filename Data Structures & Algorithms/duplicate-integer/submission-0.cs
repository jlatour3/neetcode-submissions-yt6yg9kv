public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> existing = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            if (existing.Contains(curr))
            {
                return true;
            }
            existing.Add(curr);
        }
        return false;
    }
}