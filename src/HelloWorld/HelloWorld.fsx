namespace ConsoleApp.HelloWorld

open Microsoft.FSharp.Core.Printf // Open is a equavilent of using statment.

module HelloWorld = 

    let helloWorld _ = 
        let string = "Hello World." // Declare a variable. String type is infered.
        printfn "%A" string // "%A" is Any formatting
        //  https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/plaintext-formatting#format-specifiers-for-printf
        