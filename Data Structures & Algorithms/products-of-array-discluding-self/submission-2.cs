public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] output = new int[nums.Length];
        int[] prefix = new int[nums.Length + 1];
        int[] postfix = new int[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            prefix[i] = 1;
            postfix[i] = 1;
        }
        prefix[0] = nums[0];
        postfix[nums.Length - 1] = nums[nums.Length - 1];

        for(int i = 1, j = nums.Length - 2; i < nums.Length; ++i, --j)
        {
            prefix[i] = nums[i] * prefix[i - 1];
            postfix[j] = nums[j] * postfix[j + 1];
        }
        for(int i = 0; i < nums.Length; ++i)
        {
            if (i == 0)
                output[i] = postfix[i + 1];
            else if (i == nums.Length - 1)
                output[i] =  prefix[i - 1];
            else
                output[i] = prefix[i - 1] * postfix[i + 1];
        }




        return output;
    }
}