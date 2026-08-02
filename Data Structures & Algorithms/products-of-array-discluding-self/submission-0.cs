public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] output = new int[nums.Length];
        int total = 1;
        int zeroCount = 0;
        List<int> idxx = new List<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
            {
                ++zeroCount;
                continue;
            }
            
            total *= nums[i];
        }

       
        for (int i = 0; i < nums.Length; ++i)
        {
            if (zeroCount > 1)
                output[i] = 0;

            if (nums[i] != 0 && zeroCount == 0)
            {
                output[i] = total / nums[i];
            }

            if (nums[i] != 0 && zeroCount >= 1)
            {
                output[i] = 0;
            }

            if (nums[i] == 0 && zeroCount == 1)
                output[i] = total;
        }


            return output;
    }
}