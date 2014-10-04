function findMaxSequence(value) {
    var i;
    var currSequence = [value[0]];
    var maxSequence = [value[0]];

    for (i = 1; i < value.length; i += 1) {
        currentElement = value[i];
        previousElement = value[i - 1];

        if (currentElement > previousElement) {
            currSequence.push(currentElement);

            if (i === value.length - 1 && maxSequence.length <= currSequence.length) {
                maxSequence = currSequence;
            }
        } else {

            if (maxSequence.length <= currSequence.length) {
                maxSequence = currSequence;
            }
            currSequence = [currentElement];
        }
    }

    if (maxSequence.length === 1) {
        return 'no'
    } else {
        return maxSequence;
    }
}

var value = [3, 2, 3, 4, 2, 2, 4];
console.log(findMaxSequence(value));

var value = [3, 5, 4, 6, 1, 2, 3, 6, 10, 32];
console.log(findMaxSequence(value));