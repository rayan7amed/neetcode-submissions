public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        int[] output = new int[nums1.Length];
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums1.Length; ++i)
        {
            dict.Add(nums1[i], i);
        }
        for (int i = 0; i < nums2.Length; ++i)
        {
            if (dict.ContainsKey(nums2[i]))
            {
                output[dict[nums2[i]]] = -1;
                for (int j = i; j < nums2.Length; ++j)
                {
                    if (nums2[j] > nums2[i])
                    {
                        output[dict[nums2[i]]] = nums2[j];
                        break;
                    }
                }
            }

        }

        return output;
    }
}