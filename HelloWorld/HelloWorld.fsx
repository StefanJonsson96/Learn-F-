open Microsoft.FSharp.Core.Printf // Open is a equavilent of using statment.

let helloWorld _ = 
    let string = "Hello World." // Declare a variable. String type is infered.
    printfn "%A" string // "%A" is Any formatting
                 // https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/plaintext-formatting#format-specifiers-for-printf

[<EntryPoint>] // Where the program starts. 
    helloWorld // Call the function
    0 // Exit code 0

// To run Ctrl + A => Alt + Enter