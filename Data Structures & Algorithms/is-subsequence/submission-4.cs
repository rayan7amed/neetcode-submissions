public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s == "")
            return true;
        
        for(int i = 0, j = 0; i < t.Length && j < s.Length; ++i)
        {
            if(s[j] == t[i])
            {
                if (j == s.Length - 1)
                    return true;
                ++j;
            }
        }

        return false;
    }
}