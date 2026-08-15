
public class Solution {
    public bool IsAnagram(string s, string t) {
       string sorted_s = string.Concat(s.OrderBy(c => c));
       string sorted_t = string.Concat(t.OrderBy(c => c));
       if(sorted_s==sorted_t){
        return true;
       }
       else{
        return false;
       }
    }
}
