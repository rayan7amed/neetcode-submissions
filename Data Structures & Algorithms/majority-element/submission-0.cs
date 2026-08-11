public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();

        foreach (int i in nums)
        {
            if (map.ContainsKey(i))
                ++map[i];
            else
                map.Add(i, 1);
        }
        int maj = nums.Length / 2;
        foreach (var i in map)
        {
            if (i.Value > maj)
                return i.Key;
        }
        return -1;
    }
}