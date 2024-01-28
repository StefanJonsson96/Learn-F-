namespace ConsoleApp.Tuples

module Tuples =      

    let tupleDeclaration _ = 
        let tuple = (1, "a")
        printfn "%A" tuple
        0

    let getFirstValueFromTuple _ =
        let tuple = (1, "a")
        let num = fst tuple // fst is a built in function to get 1st value from a tuple
        printfn "%A" num
        0

    let getSecondValueFromTuple _ = 
        let tuple = (1, "a")
        let num = snd tuple // snd is a built in function to get 2nd value from a tuple
        printfn "%A" num
        0
    
    let getThirdValueFromTuple (_, _, c) = c // the _ syntax is for ignoring the first and second value, dont make to large tuples due to this limitation

    let tryGetThirdValueFromTuple _ =
        let tuple = (1, "b", 3.5)
        let third = getThirdValueFromTuple tuple
        printfn "%A" third
        0
        
    
        
        