public class Solution
{
    public int CountSeniors(string[] details)
    {
        string age = "";
        int count = 0;
        foreach (string s in details)
        {
            age = s.Substring(11, 2);
            if (int.Parse(age) > 60)
                ++count;
        }

        return count;
    }
}