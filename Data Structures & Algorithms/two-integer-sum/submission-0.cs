public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> answerToIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            int ans = target - curr;
            int indexOutput = -1;
            if (answerToIndex.TryGetValue(ans, out indexOutput))
            {
                return [indexOutput, i];
            }
            answerToIndex.Add(curr, i);
        }
        return [0, 0];
    }
}
