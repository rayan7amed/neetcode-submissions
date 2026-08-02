public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int size = 0;
        bool foundChar = false;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if (foundChar && s[i] == ' ')
                break;
            else if (!foundChar && s[i] != ' ')
{                foundChar = true;++size; }
            else if (foundChar && s[i] != ' ')
                ++size;
        }

        return size;
    }
}