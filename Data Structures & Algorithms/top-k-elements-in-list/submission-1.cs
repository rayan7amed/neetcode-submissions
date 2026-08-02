public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] result = new int[k];

        List<List<int>> list = new List<List<int>>();
        Dictionary<int, int> counts = new Dictionary<int, int>();

        for (int i = 0; i <= nums.Length; ++i)
            list.Add(new List<int>());

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

        foreach (var count in counts)
        {
            list[count.Value].Add(count.Key);
        }

        int tmp = 0;
        for(int i = list.Count - 1; i >= 0 && tmp < k; --i)
        {
            foreach (var num in list[i])
            {
                result[tmp++] = num;
               
                if (tmp == k)
                    return result;
            }
        }

        return result;
    }
}