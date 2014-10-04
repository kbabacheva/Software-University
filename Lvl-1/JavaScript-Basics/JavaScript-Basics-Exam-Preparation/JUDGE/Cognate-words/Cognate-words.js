function Solve(args) {

    Array.prototype.clean = function (deleteValue) {
        for (var i = 0; i < this.length; i++) {
            if (this[i] == deleteValue) {
                this.splice(i, 1);
                i--;
            }
        }
        return this;
    };

    function reg(a, b) {
        for (var i = 0; i < a.length; i++) {
            if (a[i] === b) {
                return false;
            }

        }
        return true;
    }

    var yourVar = args[0];
    var words = [];
    words = yourVar.split(/[^a-zA-Z]/g);
    var result = words.clean('');

    var arr = [];
    var finalResult = '';
    for (var i = 0; i < result.length; i++) {
        for (var j = 0; j < result.length; j++) {
            for (var k = 0; k < result.length; k++) {
                var str = result[i] + result[j];
                if (str === result[k]) {
                    if (i !== j) {
                        var tempStr = words[i] + "|" + words[j] + "=" + words[k];
                        if (reg(arr, tempStr)) {
                            arr.push(tempStr);
                        }
                    }
                }
            }
        }
    }
    if(arr.length === 0){
        finalResult = 'No';
    }
    else{

        for(var i = 0 ; i < arr.length ; i++){
            if (i < arr.length - 1) {
                finalResult += arr[i] + "\n";
            }
            else {
                finalResult += arr[i];
            }
        }

    }
    return finalResult;
}

args = ['Uni(lo,.ve=I love SoftUni (Soft)'];
console.log(Solve(args));