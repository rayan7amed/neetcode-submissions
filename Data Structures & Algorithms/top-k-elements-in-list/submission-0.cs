public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] result = new int[k];
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (counts.ContainsKey(nums[i]))
            {
                counts[nums[i]]++;
            }
            else
            {
                counts.Add(nums[i], 1);
            }
        }


        return counts.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}