function traverse(selector) {
    var node = document.querySelector(selector);
    traverseNode(node, '');

    function traverseNode(node, spacing) {
        spacing = spacing || '  ';
        var id = node.getAttribute('id');
        var classCSS = node.getAttribute('class');
        console.log(spacing + node.nodeName + ":" + (id?'"id=' + id + '"':'') + (classCSS? '"class=' + classCSS + '"':''));
        for (var i = 0, len = node.childNodes.length; i < len; i += 1) {
            var child = node.childNodes[i];
            if (child.nodeType === document.ELEMENT_NODE) {
                traverseNode(child, spacing + '  ');
            }
        }
        console.log(spacing + '/' + node.nodeName);
    }
}
var selector = ".birds";
traverse(selector);
console.log("----------------------------");
selector = ".mammals";
traverse(selector);