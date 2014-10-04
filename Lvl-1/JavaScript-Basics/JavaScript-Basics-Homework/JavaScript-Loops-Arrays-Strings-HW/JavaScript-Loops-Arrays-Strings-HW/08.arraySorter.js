function sortArray(value) {
    var arr = value.sort(function (a, b) { return a - b });
    return arr;
}
var value = [5, 4, 3, 2, 1];
console.log(sortArray(value));