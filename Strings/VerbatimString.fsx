namespace ConsoleApp.Strings

module VerbatimString = 

    let verbatimString _ =
        let verbatimString = @"<xml>I can have quotes "" in my verbatim string</xml>"
        printfn "%A" verbatimString // verbatim strings with the @ operator works same as c#
        0
