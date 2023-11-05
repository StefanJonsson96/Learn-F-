namespace ConsoleApp.Collections

open System.Collections.Generic

module PipeForwardOperatorList =      
    let pipeForward _ = // notice how pipe forward |> is used to chain calls
        let list = [1;5;15;25;] // notice how fun x -> is equavilent of x => in c#  
        let result = list |> List.map(fun x -> x*2) // map is equavilent of select in c# linq
                          |> List.filter(fun x -> x <> 2) // filter is equavilent of where in c# linq                                                                                            
        printfn "%A" result // 10; 30; 50; 1 > removed 5>10 15>30 25>50 
        0