function countSubstringOccur(value) {
    var substring = value[0].toLowerCase();
    var str = value[1].toLowerCase();
    var count = 0;
    if (str.match(new RegExp(substring, "g")) != null) {
        count = str.match(new RegExp(substring, "g")).length;
    }
        return count;
}
var value = ['in', 'We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'];
console.log(countSubstringOccur(value))