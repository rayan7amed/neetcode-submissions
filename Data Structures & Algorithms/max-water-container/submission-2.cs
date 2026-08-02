public class Solution
{
    public int MaxArea(int[] heights)
    {
        List<int> areas = new List<int>();

        int left = 0, right = heights.Length - 1, max = 0;
        
        while (left < right)
        {
            int tmp = (right - left) * Math.Min(heights[right], heights[left]);
            if (max < tmp)
            {
                max = tmp;

            }
            
            if (heights[left] < heights[right])
                ++left;
            else if (heights[left] > heights[right])
                --right; 
            else if (heights[left] == heights[right])
                ++left;
            
        }
        return max;
    }
}