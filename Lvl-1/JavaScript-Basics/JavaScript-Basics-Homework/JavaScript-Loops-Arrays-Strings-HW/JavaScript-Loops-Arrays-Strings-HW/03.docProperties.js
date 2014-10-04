function displayProperties() {
    var properties = [];
    for (var prop in Document) {
        properties.push(prop);
    }
    properties.sort();
    return properties.join('\n')
}
console.log(displayProperties());