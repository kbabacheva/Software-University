function bitChecker(value){
    console.log(((value >> 3) & 1) == 1);
}
var value = 333;
bitChecker(value);
value = 425;
bitChecker(value);
value = 2567564754;
bitChecker(value);