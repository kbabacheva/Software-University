function reverseString(value) {
    var arr = "";
    for (var i = 0; i < value.length; i++) {
        arr += value[value.length - 1 - i];
    }
    return arr;
}
var value = 'sample';
console.log(reverseString(value));

//var value = 'java script';
//console.log(reverseString(value));