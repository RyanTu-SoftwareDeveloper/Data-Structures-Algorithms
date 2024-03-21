
//https://leetcode.com/problems/group-anagrams/

public class Solution{
    public IList<IList<string>> GroupAnagrams(string[]  strs){
        var groups = new Dictionary<string, IList<string>>();

        //iterate through each strings s in the input strs
        foreach (string s in strs){
            char[] hash = new char[26]; //initialize hash array size 26 which calculate the unique signature for each string
            foreach (char c in s){
                hash[c - 'a']++; // convert character to an index in the range 0 to 25
            }

            string key = new string(hash); //the hash array is converted to string key (represent the unique signature of the anagram group)
            if (!groups.ContainsKey(key)){
                groups[key] = new List<string>(); //it not, creates a new list and adds it to dictionary with the key
            }
            groups[key].Add(s); // add the orginal string s to the list corresponding to the key
        } 
        return groups.Values.ToList(); //return a list of anagram

    }
}
// Time Complexity: O(n * m) where n is the number of strings in the input array
                            //and m is the maximum length of a string
// Space Complexity: O(n * m) use Dictionary to store unique signature and anagram list