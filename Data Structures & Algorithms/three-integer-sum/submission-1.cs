public class Solution
{

    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int j = i + 1, k = nums.Length - 1;
            int rem = -1 * nums[i];

            while (j < k)
            {
                List<int> current = new List<int> { nums[i], nums[j], nums[k] };
                if (nums[j] + nums[k] == rem)
                {
                    if (!res.Any(x => x.SequenceEqual(current)))
                        res.Add(current);
                    ++j;
                }
                if (nums[j] + nums[k] > rem)
                    --k;
                if (nums[j] + nums[k] < rem)
                    ++j;

            }

        }

        return res;
    }
}