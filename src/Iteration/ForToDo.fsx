namespace ConsoleApp.Iteration

open Microsoft.FSharp.Collections

module ForToDo =      
    let forToDoLoop _ = // the forToDo loop is the equavilent of c# for loop
        let myList = ["looping 0"; "to type each value in my list 1"; "this is the last string 2 "; "even if i have more strings 3";]
        for i in 0 .. 2 do  // notice the two dots instead of the keyword "to"
            printfn "%A" myList[i] |> ignore