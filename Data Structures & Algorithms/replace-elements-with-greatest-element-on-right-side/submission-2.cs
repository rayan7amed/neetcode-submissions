public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int[] output = arr.ToArray();
        if (arr.Length == 1)
            return new int[] { -1 };
        int max = arr[arr.Length - 1];
        for (int  i = arr.Length - 2; i >= 0; i--)
        {
            output[i] = max;
            if (max < arr[i])
                max = arr[i];
        }

        output[arr.Length - 1] = -1;

        return output;
    }
}