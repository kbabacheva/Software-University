function evenNumber(value) {
    var isEven;
    if (value % 2 === 0) {
        isEven = true;
        console.log(isEven)
    }
    else {
        isEven = false;
        console.log(isEven);
    }
}
var value = 3;
evenNumber(value);
value = 127;
evenNumber(value);
value = 588;
evenNumber(value);