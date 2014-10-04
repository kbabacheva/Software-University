function biggerThanNeighbors(index, arr) {
    var result = 0;
    if (index > arr.length - 1) {
        result = 'invalid index';
    }
    else if (index === 0 || index === arr.length - 1) {
        result = 'only one neighbor';
    }
    else {
        if (arr[index] > arr[index-1] + arr[index+1]) {
            result = 'bigger';
        }
        else if (arr[index] < arr[index - 1] + arr[index + 1]) {
            result = 'not bigger';
        }
        else {
            result = 'equal';
        }
    }
    return result;
}

var index = 2;
var arr = [1, 2, 3, 3, 5];
console.log(biggerThanNeighbors(index, arr));

var index = 2;
var arr = [1, 2, 5, 3, 4];
console.log(biggerThanNeighbors(index, arr));//there's mistake in the example, obviously 5 = 3+2

var index = 5;
var arr = [1, 2, 5, 3, 4];
console.log(biggerThanNeighbors(index, arr));

var index = 0;
var arr = [1, 2, 5, 3, 4];
console.log(biggerThanNeighbors(index, arr));