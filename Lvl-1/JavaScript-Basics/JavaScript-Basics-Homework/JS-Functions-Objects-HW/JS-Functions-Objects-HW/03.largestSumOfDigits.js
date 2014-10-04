function findLargestBySumOfDigits(nums) {
    var result = 0;
    var sum = 0;
    var maxSum = 0;
    var num = 0;
    if (typeof nums !== 'number' || nums.length === 0 || nums.cont) {
        result = 'undefined';
    }
    for (var i = 0; i < nums.length; i++) {
        if (!(nums[i] === parseInt(nums[i]))) {
            result = 'undefined';
        }
        else {
            num = nums[i];
            var buffer = num;
            num = Math.abs(num);
            while (num > 9) {
                sum = sum + num % 10;
                num = parseInt(num / 10);
            }
            sum += num;
            if (sum > maxSum) {
                maxSum = sum;
                result = buffer;
            }
        }
        sum = 0;
    }
    return result;

}
var nums = [5, 10, 15, 111];
console.log(findLargestBySumOfDigits(nums));

var nums = [33, 44, -99, 0, 20];
console.log(findLargestBySumOfDigits(nums));

var nums = ['hello'];
console.log(findLargestBySumOfDigits(nums));

var nums = [5, 3.3];
console.log(findLargestBySumOfDigits(nums));