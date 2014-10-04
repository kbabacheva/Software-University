function calcCylinderVol(radius,height) {
    var volume = radius * radius * height * Math.PI;
    volume = Math.round(volume * 1000) / 1000;
    console.log(volume);
}

var radius = 2;
var height = 4;
calcCylinderVol(radius, height);

radius = 5;
height = 8;
calcCylinderVol(radius, height);

radius = 12;
height = 3;
calcCylinderVol(radius, height);