public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int current = 0, max = 0;

        foreach(int num in nums)
        {
            if (num == 1)
            {
                ++current;
                max = Math.Max(current, max);
            }
            else
                current = 0;
        }
        return max;
    }
}