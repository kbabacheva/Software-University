function treeHouseCompare(house, tree) {
    //house
    var areaSquare = house * house;
    var areaTriangle = (house * house) / 3; //h = 2*house/3
    var houseArea = areaSquare + areaTriangle;
    houseArea = parseFloat(Math.round(houseArea * 100) / 100).toFixed(2);

    //tree
    var areaRectangle = (tree * tree) / 3;
    var areaCircle = (4 * tree * tree * Math.PI) / 9;
    var treeArea = areaCircle + areaRectangle;
    treeArea = parseFloat(Math.round(treeArea * 100) / 100).toFixed(2);

    if (Number(houseArea) > Number(treeArea)) {
        console.log('house/' + houseArea);
    }
    else if (Number(houseArea) < Number(treeArea)) {
        console.log('tree/' + treeArea);
    }
    else {
        console.log('equal' + houseArea);
    }
}

var house = 3;
var tree = 2;
treeHouseCompare(house, tree);

house = 3;
tree = 3;
treeHouseCompare(house, tree);

house = 4;
tree = 5;
treeHouseCompare(house, tree);