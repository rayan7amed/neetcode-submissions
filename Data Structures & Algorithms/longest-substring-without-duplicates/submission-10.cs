public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        HashSet<char> set = new HashSet<char>();


        for(int i = 0, j = 0; i < s.Length; ++i)
        {
            if (!set.Contains(s[i]))
            {
                set.Add(s[i]);
            }
            else
            {
                //set.Clear();
                //set.Add(s[i]);
                //for (int j = i - 1; j >= 0; j--)
                //{
                //    if (s[j] == s[i])
                //        break;
                //    set.Add(s[j]);

                //}
                while (j < i)
                {
                    set.Remove(s[j]);

                    if (s[j] == s[i])
                    {
                        ++j;
                        break;
                    }
                    j++;
                }
                set.Add(s[i]);
            }
            if (max < set.Count)
                max = set.Count;
        }



        return max;
    }
}