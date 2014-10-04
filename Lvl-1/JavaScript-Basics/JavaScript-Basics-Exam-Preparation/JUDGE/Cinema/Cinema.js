function Solve(args) {
    var type = args[0];
    var rows = Number(args[1]);
    var cols = Number(args[2]);
    var places = rows * cols;
    if (type === 'Premiere') {
        var income = (places * 12).toFixed(2);
        console.log(income + ' leva');
    }
    else if (type === 'Normal') {
        var income = (places * 7.5).toFixed(2);
        console.log(income + ' leva');
    }
    else if (type === 'Discount') {
        var income = (places * 5).toFixed(2);
        console.log(income + ' leva');
    }
}
var args = [
    'Premiere',
    '10',
    '12'
];
Solve(args);