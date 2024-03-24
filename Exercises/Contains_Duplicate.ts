/**
 * Check if the given array contains any duplicate elements.
 * @param {number[]} nums - The array of numbers to check.
 * @returns {boolean} - True if there are duplicates, false otherwise.
 */
const containsDuplicate = (nums: number[]): boolean => {
    return nums.length !== new Set(nums).size;
};

console.log(containsDuplicate([1, 2, 3]));
