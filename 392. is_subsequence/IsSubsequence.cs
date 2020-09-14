public class IsSubseq {
    public bool IsSubsequence(string s, string t) {
        int sIndex = 0;
        
        if (string.IsNullOrEmpty(s)) return true;
        
        for (var i = 0; i < t.Length; i++) {
            if (t[i] == s[sIndex]) sIndex++;
            if (sIndex == s.Length) return true;
        }
        
        return false;
    }
}


/*
Given a string s and a string t, check if s is subsequence of t.

A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, "ace" is a subsequence of "abcde" while "aec" is not).

Follow up:
If there are lots of incoming S, say S1, S2, ... , Sk where k >= 1B, and you want to check one by one to see if T has its subsequence. In this scenario, how would you change your code?

Credits:
Special thanks to @pbrother for adding this problem and creating all test cases.

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
 

Constraints:

0 <= s.length <= 100
0 <= t.length <= 10^4
Both strings consists only of lowercase characters.


*/