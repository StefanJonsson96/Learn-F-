open System.Text
open Microsoft.FSharp.Core.Printf

let stringBuilder _ = 
    let builder = StringBuilder()
    builder.Append("Hejsan ") |> ignore // Stringbuiilder is good at working with strings in f# since strings are immutable.
    builder.Append("Hoppsan") |> ignore // Since we dont care about the value "Hoppsan" on its own, but the completed string, its good practise to explicitly ignore the append rows.
    builder.Append(" ") |> ignore
    printfn "%A" (builder.ToString()) // you need to add () when you use function or method calls, in c# it would just be builder.ToString()
    
[<EntryPoint>] // Where the program starts. 
    stringBuilder // Call the function
    0 // Exit code 0

// To run Ctrl + A => Alt + Enter