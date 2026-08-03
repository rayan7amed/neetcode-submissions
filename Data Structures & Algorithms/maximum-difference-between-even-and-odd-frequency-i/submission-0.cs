public class Solution
{
    public int MaxDifference(string s)
    {

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (map.ContainsKey(c))
            {
                map[c]++;
            } else
            {
                map.Add(c, 1);
            }
        }
           
        int maxOdd = map.Where(x => x.Value % 2 != 0).Max(x => x.Value);
        int minEven = map.Where(x => x.Value % 2 == 0).Min(x => x.Value);

        return maxOdd - minEven;
    }
}