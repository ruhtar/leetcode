namespace TwoSums
{
    internal class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] resp = [1, 2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && (i != j))
                    {
                        resp[0] = i;
                        resp[1] = j;
                    }
                }
            }
            return resp;
        }
    }
}
