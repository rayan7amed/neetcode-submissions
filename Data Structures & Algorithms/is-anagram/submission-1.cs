public class Solution {
    public bool IsAnagram(string s, string t) {
        List<char> str = new List<char>();
        str.AddRange(s);
        
        foreach (char ch in t){
            if(!str.Remove(ch))
                return false;
        }

        return str.Count == 0? true : false;
    }
}