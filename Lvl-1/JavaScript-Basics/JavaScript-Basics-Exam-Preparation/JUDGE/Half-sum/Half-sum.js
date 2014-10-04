function solve(arr) {
    arr = arr.map(Number);
    var n = arr[0];
    var firstArray = 0;
    var secondArray = 0;
    var result = '';

    for (var i = 1; i <= n; i++) {
        firstArray += arr[i];
    }
    for (var j = n+1; j <= 2*n; j++) {
        secondArray += arr[j];
    }
    var diff = firstArray - secondArray;
    if (firstArray === secondArray) {
        result = 'Yes, sum=' + firstArray;
        return result;
    }
    else {
        result = 'No, diff=' + Math.abs(diff);
        return result;
    }
}
//console.log(solve(['4','3', '4', '-1', '-1', '2', '1', '1', '1']));