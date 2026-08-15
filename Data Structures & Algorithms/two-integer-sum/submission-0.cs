public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int result = target - nums[i];

            if (seen.ContainsKey(result))
            {
                return new int[] { seen[result], i };
            }

            seen[nums[i]] = i;
        }

        return new int[] { };
    }
}