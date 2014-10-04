function lastDigitAsText(number) {
    number %= 10;
    number = Math.abs(number);
    switch (number) {
        case 1: number = 'one'; break;
        case 2: number  = 'two'; break;
        case 3: number = 'three'; break;
        case 4: number = 'four'; break;
        case 5: number = 'five'; break;
        case 6: number = 'six'; break;
        case 7: number = 'seven'; break;
        case 8: number = 'eight'; break;
        case 9: number = 'nine'; break;
        case 0: number = 'zero'; break;
    }
    return number;
}
console.log(lastDigitAsText(6));
console.log(lastDigitAsText(-55));
console.log(lastDigitAsText(133));
console.log(lastDigitAsText(14567));