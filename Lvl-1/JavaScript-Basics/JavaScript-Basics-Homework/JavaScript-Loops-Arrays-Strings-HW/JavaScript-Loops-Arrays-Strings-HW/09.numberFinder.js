function findMostFreqNum(value) {
    var arr = value.sort(function (a, b) { return a - b });
    var count = 1;
    var maxCount = 1;
    var num = 0;
    for (var i = 1; i < arr.length; i++) {
        if (arr[i-1] === arr[i]) {
            count++;
            if (count > maxCount) {
                maxCount = count;
                num = value[i];
            }
        }
        else {
            count = 1;
        }
    }
    var result = num + ' (' + maxCount + ' times)';
    return result;
}

var value = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
console.log(findMostFreqNum(value));

var value = [2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1];
console.log(findMostFreqNum(value));