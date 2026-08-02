public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] output = new int[nums.Length];
        int[] prefix = new int[nums.Length];
        int[] postfix = new int[nums.Length];
        
        int len = nums.Length;
        prefix[0] = nums[0];
        postfix[len - 1] = nums[len - 1];

        for(int i = 1, j = len - 2; i < len; ++i, --j)
        {
            prefix[i] = nums[i] * prefix[i - 1];
            postfix[j] = nums[j] * postfix[j + 1];
        }
        for(int i = 0; i < len; ++i)
        {
            if (i == 0)
                output[i] = postfix[i + 1];
            else if (i == len - 1)
                output[i] =  prefix[i - 1];
            else
                output[i] = prefix[i - 1] * postfix[i + 1];
        }




        return output;
    }
}
