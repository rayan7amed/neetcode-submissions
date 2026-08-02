public class Solution {
    
    public int LongestConsecutive(int[] nums)
{
    HashSet<int> set = new HashSet<int>(nums);
    int max = 0;

    foreach (int num in set)
    {
        if (!set.Contains(num - 1))
        {
            int length = 1;
            int current = num;

            while (set.Contains(current + 1))
            {
                current++;
                length++;
            }

            max = Math.Max(max, length);
        }
    }

    return max;
}
}