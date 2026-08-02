public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> set = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (!set.ContainsKey(c))
                set.Add(c, 1);
            else
                set[c]++;
        }

        for (int i = 0; i < s2.Length; ++i)
        {
            if (set.ContainsKey(s2[i]))
            {
                int j = i, count = 0;
                var tmp = new Dictionary<char, int>(set);
                while (j < s2.Length && count < s1.Length)
                {
                    if (!tmp.ContainsKey(s2[j]))
                        break;
                    --tmp[s2[j++]];
                    ++count;
                }
                if (tmp.All(x => x.Value == 0))
                    return true;
            }
        }

        return false;
    }
}
