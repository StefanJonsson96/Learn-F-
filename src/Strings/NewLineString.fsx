namespace ConsoleApp.Strings

module NewLineString = 

    let newLineString _ =
        let string ="hejsan
        new line here" // strings are indented as u write them, no need to write \r \n, u just indent the string. 
        let ignoreIndenation = "hejsan\
        no new line here "// if you want to ignore that behaviour, just put a \ before new line, and the string will stay on the same line
        printfn "%A" string
        printfn "%A" ignoreIndenation
        0