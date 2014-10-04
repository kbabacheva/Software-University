function Solve(args) {
    //var numbers = [];
    //for (var i = 1; i < args.length; i++) {
    //    numbers.push(parseInt(args[i]));
    //}
    var numbers = args.slice(1).map(Number);
    var bestSum = numbers[0];
    for (var i = 0; i < numbers.length; i++) {
        var currentSum = 0;
        for (var j = i; j < numbers.length; j++) {
            currentSum += numbers[j];
            if (currentSum > bestSum) {
                bestSum = currentSum;
            }
        }
    }
    return bestSum;
}
var test1 = [
    '8',
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1'
]
console.log(Solve(test1));