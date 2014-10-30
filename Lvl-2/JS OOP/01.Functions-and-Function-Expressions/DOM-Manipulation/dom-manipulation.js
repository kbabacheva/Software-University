var domModule = function () {

    function appendCild() {
        var element = arguments[0];
        var appendTo = document.querySelector(arguments[1]);
        appendTo.appendChild(element);
    }

    function removeChild() {
        var removeFrom = document.querySelector(arguments[0]);
        var child = removeFrom.querySelector(arguments[1]);

        removeFrom.removeChild(child);
    }

    function addHandler() {
        var elements = document.querySelectorAll(arguments[0]);
        var event = arguments[1];
        var func = arguments[2];
        for (var i = 0; i < elements.length; i++) {
            elements[i].addEventListener(event, func);
        }
    }

    function retrieveElements() {
        var elements = document.querySelectorAll(arguments[0]);
        return elements;
    }

    var self = {
        appendChild: appendCild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    }

    return self;
}();

