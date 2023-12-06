/**
 * @param {string[]} strs
 * @return {string}
 */
//https://leetcode.com/problems/longest-common-prefix/
var longestCommonPrefix = function(strs) {
    let prefix = "";
    let count = 0
    let charArray = strs[count].split("");

    let flag = true;

    for (let index = 0; index < charArray.length; index++) {
        if(!flag) return prefix;
        let letter = charArray[index];

        for (let j = 1; j < strs.length; j++) {
            const element = strs[j];
            let elementCharArray = element.split("");
            if(elementCharArray[index] !== letter || !element ){
                flag = false;
                return prefix;
            }
        }
        if(!flag) return prefix;

        prefix += letter
    }
    return prefix;
};


console.log(longestCommonPrefix(["flower","flower","flower","flower"]));
