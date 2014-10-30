var specialConsole = function () {
    var str;
    function writeLine() {
        var message = arguments[0];
        if (arguments.length <= 1) {
            consoleWrite(message);
        } else if(arguments.length > 1){
            var args = Array.prototype.slice.call(arguments);
            message = placeholder(message, args.slice(1, args.length));
            consoleWrite(message);
        }
    }

    function placeholder(str, args) {
        for (var i = 0; i < args.length; i++) {
            str = str.replace('{' + i + '}', args[i].toString());
        }

        return str;
    }

    function consoleWrite(str) {
        console.log(str.toString());
    }

    var self = {
        writeLine: writeLine,
        writeError: writeLine,
        writeWarning: writeLine
    }

    return self;
}();

specialConsole.writeLine("Hello!");
specialConsole.writeLine("Hello, {0}", "stranger!");
specialConsole.writeError("Error: {0}", "Invalid operation exception!");
specialConsole.writeWarning("Warning: {0}", "You shouldn't declare variables in the global scope!");
specialConsole.writeLine("My name is {0} {1} and I am {2} years old","Pesho","Petrov","18");
