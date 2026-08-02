public class Solution
{
    public List<List<Pair>> InsertionSort(List<Pair> pairs)
    {
        List<List<Pair>> res = new List<List<Pair>>();
        
        for (int i = 0; i < pairs.Count; ++i)
        {
            Pair curr = pairs[i];
            int j = i - 1;
            
            while (j >= 0 && curr.Key < pairs[j].Key)
            {
                pairs[j + 1] = pairs[j];
                j = j - 1;
            }
            
            pairs[j + 1] = curr;
            res.Add(new List<Pair>(pairs));
        }
        
        return res;
    }
}