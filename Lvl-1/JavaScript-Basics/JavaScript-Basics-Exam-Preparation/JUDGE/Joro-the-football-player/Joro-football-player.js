function Solve(args) {
    var year = args[0];
    var holidays = Number(args[1]);
    var hometown = Number(args[2]);
    var normal = 52 - hometown;
    var holidaysPlay = holidays / 2;
    var playingNormal = (2 * normal) / 3;
    var totalPlay = hometown + playingNormal + holidaysPlay;
    totalPlay = Math.floor(totalPlay);
    if (year === 't') {
        return (totalPlay + 3);
    }
    else {
        return totalPlay;
    }
}
//var args = ['t', '1', '2'];
//console.log(Solve(args));