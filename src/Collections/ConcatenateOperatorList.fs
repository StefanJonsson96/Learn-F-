namespace ConsoleApp.Collections

module ConcatenateOperatorList =      

    let concatenateOperator _ = 
        let myList = [1;2;3;]
        let myOtherList = [4;5;6;]
        let concatList = myList@myOtherList // @ operator concats lists
        printfn "%A" concatList
        0        