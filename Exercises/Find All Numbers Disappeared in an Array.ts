//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/submissions/
function findDisappearedNumbers(nums: number[]): number[] {
  let set = new Set(nums);
  let missingNumbers: number[] = [];
  for (let index = 1; index <= nums.length; index++) {
    if (!set.has(index)) {
      missingNumbers.push(index);
    }
  }

  return missingNumbers;
}

console.log(findDisappearedNumbers([1, 1]));
