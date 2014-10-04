function findMinAndMax(value) {
    var input = value.map(Number);
    var arr = input.sort(function (a, b) { return a - b });
    var min = 'Min -> ' + arr[0];
    var max = 'Max -> ' + arr[arr.length - 1];
    return min + '\n' + max;
}
value = [1, 2, 1, 15, 20, 5, 7, 31];
console.log(findMinAndMax(value));

//value = [2, 2, 2, 2, 2];
//console.log(findMinAndMax(value));

//value = [500, 1, -23, 0, -300, 28, 35, 12];
//console.log(findMinAndMax(value));