public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        int[] res = new int[length];
        for (int i = 0; i < length; i++)
        {
            int product = 1;
            for (int j = 0; j < length; j++)
            {
                if (i != j)
                {
                    product = nums[j] * product;
                }
            }
            res[i] = product;
        }
        return res;
    }
}
