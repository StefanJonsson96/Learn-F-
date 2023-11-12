namespace ConsoleApp.Iteration

open System
open System.Threading.Tasks
open System.IO

module FunctionalForLoop=      
    let listIteration _ = 
        let list = [1; 2; 3;]
        List.iter(fun x -> printfn "%A" x) list // The iter function does something on each element of the collection. This is more common in F#, we try to avoid loops.
        0