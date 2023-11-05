namespace ConsoleApp.Collections

module Array =      

    let arrayTest _ =  
        let myArray = [|1.; 5; 10.|] // pipes needed to declare array
        myArray[0] <- 69 // Arrow operator changes value of something mutable (NOT VARIABLES; but values in an array!)
        printfn "%A" myArray[0] 
        0