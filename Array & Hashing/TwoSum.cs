/*
https://leetcode.com/problems/two-sum/description/

*/


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            if (indices.ContainsKey(diff)) {
                return new int[] {indices[diff], i};
            }
            indices[nums[i]] = i;
        }
        return null;
    }
}

/*
Time Complexity: O(n) where n is the number of elements in the nums array
                    and it traverses the array exactly once
Space Complexity: O(n) use dictionary to store elements
*/