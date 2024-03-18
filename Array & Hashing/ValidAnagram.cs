public class Solution{
    public bool IsAnagram(string s, string t){
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count frequency of characters in both strings
        foreach (char c in s)
        {
            if (!charCount.ContainsKey(c))
                charCount[c] = 0;
            charCount[c]++;
        }
        foreach (char c in t)
        {
            if (!charCount.ContainsKey(c))
                return false; // Character not present in s
            charCount[c]--;
            if (charCount[c] < 0)
                return false; // More occurrences of character c in t than in s
        }

        return true;
    }
}

/*
Time Complexity: O(n) n is the length of strings and iterates over both strings once
Space Complexity: O(n) use Dictionary to store character frequencies

*/