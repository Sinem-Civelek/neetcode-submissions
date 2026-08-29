public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

       
                Dictionary<int, int> seen = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (!seen.ContainsKey(nums[i]))
                    {
                        seen.Add(nums[i], 1);
                    }
                    else
                    {
                        seen[nums[i]]++;
                    }
                }
                int[] result = seen.OrderByDescending(p=>p.Value).Take(k).Select(p=>p.Key).ToArray();

                return result;
    }
}
