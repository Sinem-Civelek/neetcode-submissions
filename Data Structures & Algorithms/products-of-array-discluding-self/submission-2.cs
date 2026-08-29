public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         
            int all = 1;

            int[] indices = nums.Select((value, index) => new { value, index }).Where(x => x.value == 0)
               .Select(x => x.index)
               .ToArray();

          
            if (indices.Length > 1)
            {
                Array.Clear(nums, 0, nums.Length);
                return nums;
            }


            else if (indices.Length==1)
            {
               
                foreach (int num in nums)
                {
                    if (num != 0)
                    {
                        all *= num;
                    }
                }
                Array.Clear(nums, 0, nums.Length);
                foreach (int i in indices)
                {
                    nums[i] = all;
                }

            }


            else
            {
                all = nums.Aggregate(1, (acc, x) => acc * x);
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = all / nums[i];
                }
            }

            return nums;
    }
}
