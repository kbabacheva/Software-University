function Solve(args) {
    var wheelsCount = parseInt(args[0]);
    var combinations = 0;
    var currentSolution;
    for (var trucks = 0; trucks <= wheelsCount / 10; trucks++) {
        for (var cars = 0; cars <= wheelsCount / 4; cars++) {
            for (var trikes = 0; trikes <= wheelsCount / 3; trikes++) {
                currentSolution = trucks * 10 + cars * 4 + trikes * 3;
                if (currentSolution === wheelsCount) {
                    combinations++;
                }
                else if (currentSolution > wheelsCount) {
                    break;
                }
            }
        }
    }
    return combinations;
}
var args = '7';
console.log(Solve(args));