function Solve(args) {
    var input = args.split(" ");
    var arr = [];
    for (var i = 0; i < input.length; i++) {
        arr[i] = Number(input[i]);
    }
    arr = arr.sort(function (a, b) { return b - a }); // sorting in descending way, so the biggest number is arr[0]
    var sumOfOtherElements = 0;
    for (var i = 1; i < input.length; i++) {
        sumOfOtherElements += arr[i];
    }
    if (arr[0] === sumOfOtherElements) {
        var result = 'Yes, sum=' + arr[0];
        console.log(result);
    }
    else {
        var result = 'No, diff=' + Math.abs(arr[0] - sumOfOtherElements);
        console.log(result);
    }
}

var args = '3 4 1 1 2 12 1';
console.log(Solve(args));