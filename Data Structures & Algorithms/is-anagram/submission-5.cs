public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        if (s.Length != t.Length) return false;
        foreach (char c in s)
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map.Add(c, 1);
        }

        foreach(char c in t)
        {
            if (!map.ContainsKey(c))
                return false;
            else if (map[c] == 1)
                map.Remove(c);
            else if (map[c] > 1)
                map[c]--;
        }
        return true;
    }
}