public class Solution
{
    public int getDigits(int num)
    {
        if (num == 0) return 1;
        num = Math.Abs(num);

        int counter = 0;
        while(num > 0) 
        {
            num = num / 10;
            counter++;
        }
        return counter;
    }
    public string Encode(IList<string> strs)
    {
        string result = "";

        int strCount = strs.Count;
        int strCountDigits = getDigits(strCount);

        result = result + strCountDigits + strCount;
        
        foreach (string str in strs)
            result = result + getDigits(str.Length).ToString() + str.Length;
        
        foreach (string str in strs)
            result += str;

        return result;
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        List<int> sizes = new List<int>();

        int stringCounts = 0;
        int stringCountsDigits = s[0] - '0';
        int counter = 1;

        stringCounts = int.Parse(s.Substring(counter, stringCountsDigits));
        counter += stringCountsDigits;

        int initial = counter;
        while (sizes.Count < stringCounts)
        {
            int sizeOfLength = s[counter++] - '0';      
            sizes.Add(int.Parse(s.Substring(counter, sizeOfLength)));
            counter = counter + sizeOfLength;
        }

        foreach (int size in sizes)
        {
            result.Add(s.Substring(counter, size));
            counter += size;
        }

        return result;
    }
}