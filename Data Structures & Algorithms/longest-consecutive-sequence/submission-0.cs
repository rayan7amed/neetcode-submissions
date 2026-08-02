public class Solution
{

    public int LongestConsecutive(int[] nums)
    {
        System.Collections.Hashtable ht = new System.Collections.Hashtable();
        int max = 0;
        foreach (int num in nums)
        {
            if (!ht.ContainsKey(num))
                ht.Add(num, true);
            
        }
        foreach (int num in nums)
        {
            if (ht.ContainsKey(num - 1))
                ht[num] = false;
        }
        foreach (int num in nums)
        {
            if ((bool)ht[num] == true)
            {
                int starter = num;
                int counter = 1;

                while (ht.ContainsKey(++starter))
                {
                    ++counter;
                }
                if (counter > max)
                    max = counter;
            }
        }
                


        return max;
    }
}