function compareChars(arr1,arr2) {
    for (var i = 0; i < arr1.length; i++) {
        if (arr1[i] !== arr2[i]) {
            return 'Not equal';
            break;
        }
        else {
            return 'Equal';
        }
    }
}
var arr1 = ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'];
var arr2 = ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'];
console.log(compareChars(arr1, arr2));

//var arr1 = ['3', '5', 'g', 'd'];
//var arr2 = ['5', '3', 'g', 'd'];
//console.log(compareChars(arr1, arr2));