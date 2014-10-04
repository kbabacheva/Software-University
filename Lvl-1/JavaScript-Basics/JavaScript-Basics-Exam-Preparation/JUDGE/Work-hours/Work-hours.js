function Solve(args) {
    var input = args.map(Number);
    var requiredHours = input[0];
    var availableDays = input[1];
    var productivity = input[2];
    var daysWithoutBiking = availableDays - availableDays * 10 / 100;
    var availableHours = (12 * daysWithoutBiking * productivity) / 100;
    availableHours = Math.floor(availableHours);
    if (availableHours >= requiredHours) {
        console.log('Yes');
        console.log(availableHours - requiredHours);
    }
    else {
        console.log('No');
        console.log(availableHours - requiredHours);
    }
}
var args = [
    '1',
    '1',
    '100'
]
Solve(args);