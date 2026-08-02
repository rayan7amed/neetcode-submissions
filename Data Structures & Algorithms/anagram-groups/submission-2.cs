public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        if (strs.Length == 0)
            return new List<List<string>> { strs.ToList() };
        
        List<List<string>> res = new List<List<string>>();
        List<string> strs2 = strs.ToList();

        for(int i = 0; i < strs2.Count; ++i)
        {
            List<string> sublist = new List<string>();
            sublist.Add(strs2[i]);

            for (int j = i + 1; j < strs2.Count; ++j)
            {
                if (IsAnagram(strs2[i], strs2[j]))
                {
                    sublist.Add(strs2[j]);
                    strs2.RemoveAt(j);
                    --j;
                }

            }
            res.Add(sublist);
        }


        return res;
    }
    public bool IsAnagram(string s, string t)
    {
        List<char> str = new List<char>();

        foreach (char ch in s)
        {
            str.Add(ch);
        }

        foreach (char ch in t)
        {
            if (!str.Remove(ch))
                return false;
        }

        return str.Count == 0 ? true : false;
    }
}