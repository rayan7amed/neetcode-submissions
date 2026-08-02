public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] result = new int[k];

        Dictionary<int, int> counts = new Dictionary<int, int>();

        List<List<int>> sortedCounts = new List<List<int>>();
        for (int i = 0; i <= nums.Length; ++i)
            sortedCounts.Add(new List<int>());

        for (int i = 0; i < nums.Length; ++i)
        {
            if (counts.ContainsKey(nums[i]))
                counts[nums[i]]++;
            else
                counts.Add(nums[i], 1);

        }

        foreach (var count in counts)
            sortedCounts[count.Value].Add(count.Key);

        int idx = 0;
        for(int i = sortedCounts.Count - 1; i >= 0 && idx < k; --i)
        {
            foreach (var num in sortedCounts[i])
            {
                result[idx++] = num;

                if (idx == k)
                    break;
            }
        }

        return result;
    }
}