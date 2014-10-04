function Solve(args) {
    var sizes = args[0].split(' ');
    var rows = parseInt(sizes[0]);
    var cols = parseInt(sizes[1]);
    var startPosition = args[1].split(' ');
    var row = parseInt(startPosition[0]);
    var col = parseInt(startPosition[1]);
    var lab = args.slice(2);
    var visited = {};
    var sum = 0;
    var count = 0;
    var directions = {
        u: {
            row: -1,
            col: 0
        },
        r: {
            row: 0,
            col: +1
        },
        d: {
            row: +1,
            col: 0
        },
        l: {
            row: 0,
            col: -1
        }
    };

    function getValueAt(row,col,cols) {
        return row * cols + col + 1;
    }

    function inRange(value, border) {
        return 0 <= value && value < border;
    }

    while (true) {
        // check if outside of labyrinth
        if (!inRange(row,rows) || !inRange(col,cols)) {
            return 'out ' + sum;
        }
        var cellValue = getValueAt(row, col, cols);

        if (visited[cellValue]) {
            return 'lost ' + count;
        }

        //check if on visited cell
        sum += cellValue;
        count++;
        visited[cellValue] = true;

        var dir = lab[row][col];
        row += directions[dir].row;
        col += directions[dir].col;

    }
}

var test1 = [
 "3 4",
 "1 3",
 "lrrd",
 "dlll",
 "rddd"
];
console.log(Solve(test1));