namespace ConsoleApp.Collections

module IntRangesArray =      

    let intRanges _ = 
        let intRangeArray = [|1..5|] // .. syntax is a range, so 1..5 => 1 2 3 4 5
        let intRangeArray2 = [|10..10..100|] // you can also have an optional 2nd parameter "how much you want to increment", so 10..10..100 would be 10 20 30 40 50 60 70 80 90 100
        printfn "%A" intRangeArray
        printfn "%A" intRangeArray2
        0