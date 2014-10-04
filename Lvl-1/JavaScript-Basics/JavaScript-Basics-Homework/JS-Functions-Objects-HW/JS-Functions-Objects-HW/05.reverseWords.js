function reverseWordsInString(str) {
    String.prototype.reverse = function () { return this.split("").reverse().join(""); }
    //return str.split("").reverse().join("");
    var arr = [];
    arr = str.split(' ');
    for (var i = 0; i < arr.length; i++) {
        arr[i] = arr[i].reverse();
    }
    arr = arr.join(' ');
    return arr;
}

str = 'Hello, how are you.';
console.log(reverseWordsInString(str));

str = 'Life is pretty good, isn’t it?';
console.log(reverseWordsInString(str));