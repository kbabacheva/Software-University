function Solve(args) {
    var input = args.map(Number);
    var sum = input[0];
    var diff = input[1];
    var number;
    var foundAny = false;
    function sumDigits(number) {
        var first = Math.floor(number / 100);
        var second = Math.floor(number % 100 / 10);
        var third = Math.floor(number % 10);
        return first + second + third;
    }
    function isCorrect(number) {
        var first = Math.floor(number / 100);
        var second = Math.floor(number % 100 / 10);
        var third = Math.floor(number % 10);
        return first > 4 && first < 10 && second > 4 && second < 10 && third > 4 && third < 10;
    }
    for (var n1 = 555; n1 <= 999; n1++) {
        var n2 = n1 + diff;
        var n3 = n1 + 2 * diff;

        if (sumDigits(n1) + sumDigits(n2) + sumDigits(n3) === sum && isCorrect(n1) && isCorrect(n2) && isCorrect(n3)) {
            foundAny = true;
            var result = n1 + '' + n2 + '' + n3;
            var res = '';
            res = res + result;
            console.log(res);
        }
    }
    if (foundAny === false) {
        return 'No';
    }
}

args = [
    ['63'],
    ['201']
]
console.log(Solve(args));