function calcSupply(age,maxAge,amount) {
    var restOfLife = maxAge - age;
    var amountInYear = amount * 365;
    var eatenFood = Math.round(restOfLife * amountInYear);
    console.log(eatenFood + 'kg of chocolate would be enough until I am ' + maxAge +' years old.');
}
var age = 38;
var maxAge = 118;
var amount = 0.5;
calcSupply(age, maxAge, amount);

age = 20;
maxAge = 87;
amount = 2;
calcSupply(age, maxAge, amount);

age = 16;
maxAge = 102;
amount = 1.1;
calcSupply(age, maxAge, amount);