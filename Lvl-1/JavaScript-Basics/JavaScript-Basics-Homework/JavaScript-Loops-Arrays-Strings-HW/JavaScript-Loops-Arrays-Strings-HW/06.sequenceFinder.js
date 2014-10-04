function findMaxSequence(value) {
    var currentSequence = 1,
        longestSequence = 1,
        maxSeqNum = value[0];

    for (var i = 1; i < value.length; i++) {
        if (value[i - 1] === value[i]) {
            currentSequence++;
            if (currentSequence >= longestSequence) {
                longestSequence = currentSequence;
                maxSeqNum = value[i];
            }
        }
        else {
            currentSequence = 1; 
        }
    }

    var result = [];
    for (var i = 0; i < longestSequence; i++) {
        result.push(maxSeqNum);
    }
    return result;
}
var value = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
console.log(findMaxSequence(value));

//var value = ['happy'];
//console.log(findMaxSequence(value));

//var value = [2, 'qwe', 'qwe', 3, 3, '3'];
//console.log(findMaxSequence(value));