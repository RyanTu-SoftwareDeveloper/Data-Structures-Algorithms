/*
https://leetcode.com/problems/product-of-array-except-self/description/
This problem asks you to take an array of integers and 
    create another array where each element is the product of all the elements 
    in the original array except for the one at the same index. 
*/
public class Solution {
    public int[] ProductExceptSelf(int[] nums){
        int prefix = 1; // Initialize a variable to keep track of the product of elements to the left of the current index
        int postfix = 1; // Initialize a variable to keep track of the product of elements to the right of the current index
        int[] res = new int[nums.Length]; // Create an array to store the final result

        // First pass: calculate prefix products
        for(int i = 0; i < nums.Length; i++){
            res[i] = prefix; // Store the product of elements to the left of the current index in the result array
            prefix *= nums[i]; // Update the prefix product by multiplying it with the current element
        }

        // Second pass: calculate postfix products and update result array
        for(int i = nums.Length - 1; i >= 0; i--){
            res[i] *= postfix; // Multiply the prefix product with the postfix product and store it in the result array
            postfix *= nums[i]; // Update the postfix product by multiplying it with the current element
        }

        return res; // Return the final result array
    }
}

//Time Complexity: O(n) performs two passes through the input array,
//Space Complxity: O(n) used additional array 'res' to store product prefix and product postfix