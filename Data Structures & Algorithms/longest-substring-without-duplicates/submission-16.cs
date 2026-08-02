public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        HashSet<char> set = new HashSet<char>();


        for(int i = 0, j = 0; i < s.Length; ++i)
        {
            if (!set.Contains(s[i]))
                set.Add(s[i]);
            
            else
                while (!set.Add(s[i]))
                    set.Remove(s[j++]);
                
            if (max < set.Count)
                max = set.Count;
        }
        return max;
    }
}