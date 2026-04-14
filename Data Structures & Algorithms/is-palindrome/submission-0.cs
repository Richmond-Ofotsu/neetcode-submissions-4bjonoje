public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1; 

        while (left < right) 
        {
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
            } 
            else if (!char.IsLetterOrDigit(s[right])) {
                right--;
            } 
            else {
                if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                    return false; // Found a mismatch
                }
                left++;
                right--;
            }
        }
        
        // 4. If we finished the loop, it's a palindrome
        return true;
    }
}
