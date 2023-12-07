/**
 * @param {number[]} nums
 * @return {number}
 */
//https://leetcode.com/problems/missing-number/
var missingNumber = function(nums) {
    const range = nums.length;
    let sortedArray = nums.sort((a,b)=>{
        return a - b;
    })
    if(sortedArray[sortedArray.length-1]!==range){
        return range
    }

    for (let index = 0; index < sortedArray.length; index++) {
        const element = sortedArray[index];
        if(element!==index){
            return index;
        }
    }
};

console.log(missingNumber([9,6,4,2,3,5,7,0,1]))