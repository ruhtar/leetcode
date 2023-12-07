/**
 * @param {number[]} nums
 * @return {boolean}
 */
//https://leetcode.com/problems/contains-duplicate/
var containsDuplicate = function(nums) {
    return nums.length !==  new Set(nums).size
};

console.log(containsDuplicate([1,2,3,1]))