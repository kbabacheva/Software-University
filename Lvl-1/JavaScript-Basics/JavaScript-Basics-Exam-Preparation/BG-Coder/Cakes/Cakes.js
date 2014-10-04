function Solve(args) {
    var money = parseInt(args[0]);
    var cake1Price = parseInt(args[1]);
    var cake2Price = parseInt(args[2]);
    var cake3Price = parseInt(args[3]);
    var sum = 0;
    var maxSum = 0;
    for (var i = 0; i <= Math.floor(money/cake1Price); i++) {
        for (var j = 0; j <= Math.floor(money/cake2Price); j++) {
            for (var k = 0; k <= Math.floor(money/cake3Price); k++) {
                var sum = i * cake1Price + j * cake2Price + k * cake3Price;
                if (sum <= money) {
                    maxSum = Math.max(sum, maxSum);
                }
            }
        }
    }
    return maxSum
}
var args = ['110',
'13',
'15',
'17'
];
console.log(Solve(args));