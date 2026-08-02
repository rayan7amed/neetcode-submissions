public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        int[] count1 = new int[26];
        int[] count2 = new int[26];

        foreach (char c in s1)
            count1[c - 'a']++;

        int left = 0;

        for (int right = 0; right < s2.Length; right++)
        {
            count2[s2[right] - 'a']++;

            // Keep window size equal to s1 length
            if (right - left + 1 > s1.Length)
            {
                count2[s2[left] - 'a']--;
                left++;
            }

            // Compare frequency arrays
            if (count1.SequenceEqual(count2))
                return true;
        }

        return false;
    }
}