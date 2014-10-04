function Solve(args) {
    var year = args[0];
    var holidays = Number(args[1]);
    var hometown = Number(args[2]);
    var holidaysPlay = (holidays * 2) / 3;
    var normalWeekends = 48 - hometown;
    var normalWeekendsPlay = (3 * normalWeekends) / 4;
    var totalPlay = hometown + holidaysPlay + normalWeekendsPlay;
    if (year === 'leap') {
        totalPlay = Math.floor(totalPlay + (totalPlay * 15) / 100);
        return totalPlay;
    }
    else {
        totalPlay = Math.floor(totalPlay);
        return totalPlay;
    }
}
var args = [
    'leap',
    '5',
    '2',
]
console.log(Solve(args));