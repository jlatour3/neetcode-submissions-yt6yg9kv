public class Solution {
    public int LongestConsecutive(int[] nums) {
        var numSet = new HashSet<int>(nums);

        var maxCount = 0;
        foreach (var val in numSet)
        {
            if (numSet.Contains(val - 1))
                continue;

            var count = 1;
            var curr = val + 1;
            while (numSet.Contains(curr))
            {
                count++;
                curr = curr + 1;
            }

            if (count > maxCount)
                maxCount = count;
        }

        return maxCount;
    }
}

