public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        char letter;
        if (s == "")
            return true;
        for(int i = 0, j = 0; i < t.Length; ++i)
        {
            letter = s[j];
            if(letter == t[i])
            {
                if (j == s.Length - 1)
                    return true;
                ++j;
            }
        }

        return false;
    }
}