public class Solution
{
    public bool IsPalindrome(string s)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for(int i = 0; i < s.Length; ++i)
            if (char.IsLetterOrDigit(s[i]))
                stringBuilder.Append(s[i]);
        s = stringBuilder.ToString();

        for(int i = 0, j = s.Length - 1; i < j; ++i, --j)
        {
            if (char.ToLower(s[i]) != char.ToLower(s[j])) return false;
        }


        return true;
    }
}