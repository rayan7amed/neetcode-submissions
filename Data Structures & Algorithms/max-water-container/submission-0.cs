public class Solution
{
    public int MaxArea(int[] heights)
    {
        List<int> areas = new List<int>();
        for(int i = 0; i < heights.Length; ++i)
        {
            for (int j = i + 1; j < heights.Length; ++j)
                areas.Add((j - i) * Math.Min(heights[j], heights[i]));
        }
        return areas.Max(); 
    }
}