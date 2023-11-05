namespace ConsoleApp.Collections

module List =      

    let listTest _ =
        let myList = [1; 5; 10;] // List syntax has no pipes
        // myList[0] <- 69420 this doesn't work because values in list are immutable!
        printfn "%A" myList[0]
        0