public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        int[] output = new int[nums1.Length];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < nums1.Length; ++i)
        {
            dict.Add(nums1[i], -1);
        }

        for (int i = 0; i < nums2.Length; ++i)
        {
            if (i == 0)
                stack.Push(nums2[i]);

            while (stack.Count > 0 && stack.Peek() < nums2[i])
            {
                int popped = stack.Pop();
                if (dict.ContainsKey(popped))
                    dict[popped] = nums2[i];

            }
            stack.Push(nums2[i]);

        }

        return dict.Values.ToArray();
    }
}