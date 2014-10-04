function convertKWtoHP(value) {
    var hp = value * 1.34102209;
    hp = Math.round(hp * 100) / 100;
    return hp;
}
var value = 75;
console.log(convertKWtoHP(value));
value = 150;
console.log(convertKWtoHP(value));
value = 1000;
console.log(convertKWtoHP(value));