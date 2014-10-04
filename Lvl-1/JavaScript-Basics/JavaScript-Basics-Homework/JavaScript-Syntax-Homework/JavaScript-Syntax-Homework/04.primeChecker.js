function isPrime(value) {
    var prime;
    for (var i = 2; i < value; i++) {
        if (value % i === 0) {
            prime = false;
            console.log(prime);
            break;
        }
        else {
            prime = true;
            console.log(prime);
            break;
        }
    }
}
var value = 7;
isPrime(value);
var value = 254;
isPrime(value);
var value = 587;
isPrime(value);