namespace ConsoleApp.Iteration

open System
open System.Threading.Tasks
open System.IO

module WhileDo =      
    let whileDoLoop _ = 
        let mutable i = 0 // you need a side effect to stop a while loop, here i use a mutable binding
        while i < 3 do
        printfn "%A" i
        i <- i + 1 
        0 |> ignore