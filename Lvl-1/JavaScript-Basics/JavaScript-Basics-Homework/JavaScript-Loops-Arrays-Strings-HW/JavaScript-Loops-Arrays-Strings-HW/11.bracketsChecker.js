function checkBrackets(value) {
    console.log(value);
    var leftBrackets = 0;
    var rightBackets = 0;
    for (var i = 0; i < value.length; i++) {
        if (value[i] === '(') {
            leftBrackets++;
        }
        if (value[i] === ')') {
            rightBackets++;
        }
    }
    if (leftBrackets - rightBackets === 0) {
        return 'correct';
    }
    else {
        return 'incorrect'
    }
}
var value = '( ( a + b ) / 5 – d )';
console.log(checkBrackets(value));

//var value = '( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )';
//console.log(checkBrackets(value));