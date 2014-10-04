//Memory limit
function Solve(args) {
    var diff = Number(args);
    var letter = ['k', 'n', 'p', 's'];
    var lettersValue = [1, 4, 5, 3];
    var foundResult = false;
    for (var i1 = 0; i1 < letter.length; i1++) {
        for (var i2 = 0; i2 < letter.length; i2++) {
            for (var i3 = 0; i3 < letter.length; i3++) {
                for (var i4 = 0; i4 < letter.length; i4++) {
                    for (var i5 = 0; i5 < letter.length; i5++) {
                        for (var i6 = 0; i6 < letter.length; i6++) {
                            for (var i7 = 0; i7 < letter.length; i7++) {
                                for (var i8 = 0; i8 < letter.length; i8++) {
                                    var wholeSequence = letter[i1] + letter[i2] + letter[i3] + letter[i4]
                                        + letter[i5] + letter[i6] + letter[i7] + letter[i8];
                                    var firstFourLetters = lettersValue[i5] + lettersValue[i6] + lettersValue[i7] + lettersValue[i8];
                                    var secondFourLetters = lettersValue[i1] + lettersValue[i2] + lettersValue[i3] + lettersValue[i4];
                                    if (firstFourLetters - secondFourLetters === diff || secondFourLetters - firstFourLetters === diff) {
                                        foundResult = true;
                                        console.log(wholeSequence);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    if (foundResult === false) {
        console.log('No');
    }
}

var args = '16';
Solve(args);