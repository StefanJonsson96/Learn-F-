namespace ConsoleApp.Strings

module InterpolatedString =

    let interpolatedString _ = 
        let a = 1
        let b = 2
        let interpolatedString = $"Hejsan a={a} hoppsan b={b}." // String interpolation works the same as c#
        printfn "%A" interpolatedString
        0