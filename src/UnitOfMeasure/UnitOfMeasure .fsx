[<Measure>] type cm
[<Measure>] type inch
[<Measure>] type m
[<Measure>] type sec
[<Measure>] type kg 
[<Measure>] type lbs
[<Measure>] type degreeCelcius
[<Measure>] type degreeFahrenheit

let x = 1<cm>
let x2 = x + 3<cm> 
x = 4<cm> 
let m = 1<m> 
let distance = 1.0<m>
let time = 2.0<sec>
let speed = 2.0<m/sec> // you can combine units of measure with the / syntax

printfn"%A" $"x={x}, x2={x2}, m={m}, distance={distance}, time={time}, speed={speed}"
//x = m this doesn't compile because x and m doesnt have the same type of measure even though they are both ints

