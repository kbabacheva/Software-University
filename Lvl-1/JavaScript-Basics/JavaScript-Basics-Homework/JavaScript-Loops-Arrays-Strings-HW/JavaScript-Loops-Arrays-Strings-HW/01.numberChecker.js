function printNumbers(n) {
    var result = '';
    if (n <= 0) {
        return 'No';
    }
    else {
        for (var i = 1; i <= n; i++) {
            if (i % 4 !== 0 && i % 5 !== 0) {
                result += i + ', '
            }
        }
        result = result.slice(0, -2);
        return result;
    }
}

var n = 20;
console.log(printNumbers(n));
var n = -5;
console.log(printNumbers(n));
var n = 13;
console.log(printNumbers(n));