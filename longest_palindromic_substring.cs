public class Solution
{
    // https://leetcode.com/problems/longest-palindromic-substring/description/
    public string LongestPalindrome(string s)
    {
        bool isValidPalindrome(string needToValidString)
        {
            if (needToValidString.Length == 0) return false;

            if (needToValidString.Length == 1) return true;

            if (needToValidString[0] != needToValidString[needToValidString.Length - 1]) return false;

            if (needToValidString.Length >= 3)
            {
                var middleNumber = needToValidString.Length / 2;


                for (var i = 0; i <= middleNumber; i++)
                {
                    if (needToValidString[i] == needToValidString[needToValidString.Length - 1 - i])
                        continue;
                    else
                        return false;
                }
            }
            return true;

        }

        string longestPalindromeString = "";

        int maxIndex = s.Length - 1;

        for (int i = 0; i < s.Length; i++)
        {
            string currentPalindromeString = "";

            for (int j = 0; j < s.Length - i; j++)
            {
                currentPalindromeString += s[i + j];

                if (isValidPalindrome(currentPalindromeString)
                    && longestPalindromeString.Length < currentPalindromeString.Length)
                    longestPalindromeString = currentPalindromeString;

            }
        }

        return longestPalindromeString;
    }
}