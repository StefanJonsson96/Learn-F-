namespace ConsoleApp.Bindings

module LetBindings = 

    let bindings _ = // ConsoleApp.Bindings are anything that is assigned using let keyword
        let test = "hejsanHoppsan" // this is not a variable, it is a binding and it is immutable
        let test2 x y = x + y // a function is also a binding and also using let keyword
        let mutable mutableString ="hejsan" // mutable keyword makes a binding mutable
        mutableString <- "hejsanHoppsan this strong is mutable" // arrow syntax is used to assign value to mutable value
        printfn "%A" mutableString // even though this works, its not common to use mutable ConsoleApp.Bindings in f#
        0