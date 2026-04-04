public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        char[] strS = s.ToCharArray();
        char[] strT = t.ToCharArray();
        Array.Sort(strS);
        Array.Sort(strT);
        for(int i = 0; i < strS.Length; i++){
            if(strT[i] == strS[i])
                continue;
            else
                return false;
        }
        return true;
    }
}
