public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int output = nums.Length;

        for(int i = 0; i < output; ++i)
        {

            if (nums[i] == val)
            {
                for (int j = i; j < nums.Length - 1; ++j)
                {
                    nums[j] = nums[j + 1];
                }
                output--;
                --i;
            }
            
        }


        return output;
    }
}