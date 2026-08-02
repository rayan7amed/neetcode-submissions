public class Solution
{
    public string cleanEmail(string email)
    {
        bool isPlus = false;
        StringBuilder sb = new StringBuilder();
        int i = 0;
        while(email[i] != '@')
        {
            if (email[i] == '+')
                isPlus = true;

            if (email[i] != '.' && !isPlus)
                sb.Append(email[i]);

            ++i;
        }
        while(i < email.Length)
        {
            sb.Append(email[i]);
            ++i;
        }

        return sb.ToString();
    }
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> unique = new HashSet<string>();

        foreach(string email in emails)
        {

            unique.Add(cleanEmail(email));
        }


        return unique.Count;
    }
}