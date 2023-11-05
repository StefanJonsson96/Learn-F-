namespace ConsoleApp.Bindings

open System.IO

module UsingBindings = 

    let writeToFile2 fileName obj = // fileName and what to write as parameters
        try // try with is similar to try catch.
            using // using is similar to use but has a more complex syntax, use is best practise.
                (File.CreateText(fileName))
                (fun file1 -> file1.WriteLine(obj.ToString())
            ) // .DIspose is called here instead of end of function.
            printfn "%A" """Successfully written to file. Check src\bin\Debug\netx.x for result."""
        with
            | e -> eprintfn "Error writing to file %s" e.Message // eprintfn is used for error messages, not normal printfn
        