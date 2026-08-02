public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] res = new int[k];
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int[] max = new int[k];
        foreach (int i in nums)
        {
            if (freq.ContainsKey(i))
            {
                ++freq[i];

            }
            else
            { 
                freq.Add(i, 1);
            }
        }
        foreach (var i in freq)
        {
            queue.Enqueue(i.Key, i.Value);
            if (queue.Count > k)
                queue.Dequeue();    
        }

        for (int i = 0; i < k; ++i)
        {
            res[i] = queue.Dequeue();
        }

        return res;
    }
}