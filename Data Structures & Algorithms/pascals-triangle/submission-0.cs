public class Solution
{
    public List<List<int>> Generate(int numRows)
    {
        List<List<int>> output = new List<List<int>>();
        List<int> tmp = new List<int>();
        tmp.Add(1);
        output.Add(tmp);
        List<int> tmp1 = new List<int>();

        tmp1.Add(1);
        tmp1.Add(1);
        output.Add(tmp1);

        if (numRows == 1)
        { output.RemoveAt(1); return output; }
        for (int i = 1; i < numRows - 1; ++i)
        {
            List<int> nums = new List<int>();
            for(int j = 0; j < output[i].Count - 1; ++j)
            {
                if (output[i][j] == 1)
                    nums.Add(1);

                nums.Add(output[i][j] + output[i][j + 1]);
            }
            nums.Add(1);
            output.Add(nums);
        }

        return output;
    }
}