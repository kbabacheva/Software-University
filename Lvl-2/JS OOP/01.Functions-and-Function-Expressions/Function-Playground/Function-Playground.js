function noParam()
{
    console.log("Number of arguments: " + arguments.length);
    for (var i = 0; i < arguments.length; i++) {
        console.log(arguments[i] + " is type " + typeof(arguments[i]));
    }
}

//noParam();
noParam("Pesho","Gosho");
noParam(1.5,2,4);

console.log("----------");
noParam.apply(this, [1, 2, 3]);
noParam.call(this,1,2,3,4,5);