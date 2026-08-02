public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int[] output = arr.ToArray();
        
        int max = -1;
        for (int  i = arr.Length - 1; i >= 0; i--)
        {
            output[i] = max;
            if (max < arr[i])
                max = arr[i];
        }

        return output;
    }
}