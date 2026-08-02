public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums.Length + 1);
        foreach (int num in nums)
            if (!set.Add(num))
                return true;
        
        return false;
    }
}