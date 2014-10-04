function checkDigit(value) {
    var isThree = false;
    value = Math.floor(value / 100);
    value %= 10;
    if (Number(value) === 3) {
        isThree = true;
        console.log(isThree);
    }
    else {
        isThree = false;
        console.log(isThree);
    }
}

var value = 1235;
checkDigit(value);

value = 25368;
checkDigit(value);

value = 123456;
checkDigit(value);


