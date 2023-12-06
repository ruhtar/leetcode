/**
 * @param {string[]} strs
 * @return {string}
 */
//https://leetcode.com/problems/longest-common-prefix/
var longestCommonPrefix = function(strs) {
    let prefix = "";
    let charArray = strs[0].split("");

    let flag = true;

    for (let index = 0; index < charArray.length; index++) {
        if(!flag) return prefix;

        let letter = charArray[index];

        for (let j = 1; j < strs.length; j++) {
            let elementCharArray = strs[j].split("");
            if(elementCharArray[index] !== letter || !strs[j] ){
                flag = false;
                return prefix;
            }
        }

        prefix += letter
    }
    return prefix;
};


console.log(longestCommonPrefix(["flower","flower","flower","flower"]));
