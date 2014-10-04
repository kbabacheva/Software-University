function replaceSpaces(value) {
    var str = '';
    for (var i = 0; i < value.length; i++) {
        if (value[i] !== ' ') {
            str += value[i];
        }
    }
    return str;
}

var value = 'But you were living in another world tryin\' to get your message through';
console.log(replaceSpaces(value));