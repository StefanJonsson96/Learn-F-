namespace ConsoleApp.Collections

module Sets =      

  let setTest _ = // a set is immutable and automatically sorted, and every value is unique
    let mySet = [6; 2; 3; 4; 5; 6; 6;] |> Set.ofList |> Set.add 9 |> printfn "%A" // should be 2,3,4,5,6,9
    0
   

    