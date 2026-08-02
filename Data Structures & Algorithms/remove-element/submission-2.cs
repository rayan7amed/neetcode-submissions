public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int index = 0;

        foreach (int num in nums)
        {
            if (num != val)
            {
                nums[index] = num;
                index++;
            }
        }

        return index;
    }
}