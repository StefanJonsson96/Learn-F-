namespace ConsoleApp.Bindings

open System.IO

module UseBindings = 

    let writeToFile fileName obj = // fileName and what to write as parameters
        try // try with is similar to try catch.
            use file1 = File.CreateText(fileName) // Use bindings are similar to using statements in C#, they execote an idosbosable, .Dispose() is implicitly called when function is done.
            file1.WriteLine(obj.ToString())
            printfn "%A" """Successfully written to file. Check src\bin\Debug\netx.x for result."""
        with
            | e -> eprintfn "Error writing to file %s" e.Message // eprintfn is used for error messages, not normal printfn
        