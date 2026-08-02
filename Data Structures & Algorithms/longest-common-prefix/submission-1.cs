public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];
        foreach(string str in strs)
        {
            int i = 0;
            for (; i < str.Length && i < prefix.Length;)
            {
                if (str[i] == prefix[i])
                {
                    i++;
                }
                else
                    break;
            }
            prefix = str.Substring(0, i);
        }



        return prefix;
    }
}