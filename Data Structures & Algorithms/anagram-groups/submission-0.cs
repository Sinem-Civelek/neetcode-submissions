public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new();

    foreach (string str in strs)
    {
        char[] chars = str.ToCharArray();
        Array.Sort(chars);

        string key = new string(chars);

        if (!groups.ContainsKey(key))
        {
            groups[key] = new List<string>();
        }

        groups[key].Add(str);
    }

    return groups.Values.ToList();
    }
}
