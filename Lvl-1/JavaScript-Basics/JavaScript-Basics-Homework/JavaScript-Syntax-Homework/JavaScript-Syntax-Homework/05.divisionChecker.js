function divisionBy3(value) {
    var number = 0;
    while(value > 9){
        number += value % 10;
        value = Math.floor(value / 10);
    }
    number += value;
    if (number % 3 === 0) {
        console.log('the number is divided by 3 without remainder');
    }
    else {
        console.log('the number is not divided by 3 without remainder');
    }
}
var value = 12;
divisionBy3(value);
var value = 188;
divisionBy3(value);
var value = 591;
divisionBy3(value);