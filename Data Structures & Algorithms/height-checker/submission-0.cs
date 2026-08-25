public class Solution
{
    public int HeightChecker(int[] heights)
    {
        int[] expected = heights.ToArray();
        Array.Sort(expected);
        int res = 0;
        for(int i = 0; i < heights.Length; ++i)
        {
            if (expected[i] != heights[i])
                ++res;
        }

        return res;
    }
}