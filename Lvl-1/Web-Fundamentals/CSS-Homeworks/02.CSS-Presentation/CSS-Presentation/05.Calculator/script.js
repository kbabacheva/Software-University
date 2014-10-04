var answer = document.calc.result.value
function run1()
{ document.calc.result.value += "1"; }
function run2()
{ document.calc.result.value += "2"; }
function run3()
{ document.calc.result.value += "3"; }
function run4()
{ document.calc.result.value += "4"; }
function run5()
{ document.calc.result.value += "5"; }
function run6()
{ document.calc.result.value += "6"; }
function run7()
{ document.calc.result.value += "7"; }
function run8()
{ document.calc.result.value += "8"; }
function run9()
{ document.calc.result.value += "9"; }
function run0()
{ document.calc.result.value += "0"; }
function runplus()
{ document.calc.result.value += "+"; }
function runminus()
{ document.calc.result.value += "-"; }
function runmultyply()
{ document.calc.result.value += "*"; }
function rundivide()
{ document.calc.result.value += "/"; }
function runpoint()
{ document.calc.result.value += "."; }
function runclear()
{ document.calc.result.value = " "; }
function runbracketleft()
{ document.calc.result.value += "("; }
function runbracketright()
{ document.calc.result.value += ")"; }
function evalu() {
    var evalo = eval(document.calc.result.value)
    document.calc.result.value = evalo;
}