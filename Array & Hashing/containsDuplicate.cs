//https://leetcode.com/problems/contains-duplicate/description/


public class Solution{
    public bool ContainsDuplicate(int[] nums){
        HashSet<int> set = new HashSet<int>();
        foreach(int x in nums){
            if(set.Contains(x)) return true;
            set.Add(x);
        }
        return false;
    }
}

//Time Comlexity:O(n) n is the number of elements in the input array nums
    // and use foreach loop iterates through each elemen in the array

//Space Complexity:O(n) n is the number of elements in the input array nums
    // use HashSet to store unique elements from the array
