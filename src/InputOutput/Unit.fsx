namespace ConsoleApp.InputOutput

module Unit = 

    let unit _ =
        let unit = () // Unit is used when no value is needed, it is not NULL. it is more comparable to "void". To assign something unit, use the () syntax
        printfn "%A" unit // Unit cannot be ignored in pattern matches! you have to handle "unit" cases
        0 