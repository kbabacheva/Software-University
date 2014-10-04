function Solve(args) {
    var input = args.map(Number);
    var n = input[0];
    var oddSum = 0;
    var evenSum = 0;
    for (var i = 1; i <= 2*n; i++) {
        if (i % 2 === 0) {
            var num = input[i];
            evenSum += num;
        }
        else {
            var num = input[i];
            oddSum += num;
        }
    }
    if (oddSum === evenSum) {
        var result = 'Yes, sum=' + oddSum;
        return result;
    }
    else {
        var result = 'No, diff=' + Math.abs(oddSum - evenSum);
        return result;
    }

}
var args = [
    ['3'],
    ['1'],
    ['2'],
    ['3'],
    ['1'],
    ['2'],
    ['2'],
]
console.log(Solve(args));