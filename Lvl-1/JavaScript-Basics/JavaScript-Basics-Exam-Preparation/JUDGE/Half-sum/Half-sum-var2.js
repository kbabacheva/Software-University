function Solve(args) {
    var n = Number(args[0]);
    var sum1 = 0;
    var sum2 = 0;
    for (var i = 1; i <= n; i++) {
        var num = Number(args[i]);
        sum1 += num;
    }
    for (var i = n+1; i <= 2*n; i++) {
        var num = Number(args[i]);
        sum2 += num;
    }
    if (sum1 === sum2) {
        var result1 = 'Yes, sum=' + sum1;
        return result1;
    }
    else if (sum1 > sum2) {
        var result = 'No, diff=' + (sum1 - sum2);
        return result;
    }
    else {
        var result = 'No, diff=' + (sum2 - sum1);
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